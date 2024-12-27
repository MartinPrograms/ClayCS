using System.Numerics;
using ClayManaged;
using Raylib_cs;

namespace ClayRendererGL;

public class RaylibClayRenderer
{
    public static unsafe void Render(Clay_RenderCommand[] renderCommands)
    {
        foreach (var command in renderCommands)
        {
            Clay_BoundingBox boundingBox = command.boundingBox;

            switch (command.commandType)
            {
                case Clay_RenderCommandType.CLAY_RENDER_COMMAND_TYPE_NONE:
                    break;
                case Clay_RenderCommandType.CLAY_RENDER_COMMAND_TYPE_TEXT:
                    var text = command.text.chars;
                    Font font = RaylibManager.GetFont(command.config.textElementConfig.fontId);
                    Raylib.DrawTextEx(
                        font,
                        text,
                        new Vector2(boundingBox.x, boundingBox.y),
                        command.config.textElementConfig.fontSize,
                        command.config.textElementConfig.letterSpacing,
                        command.config.textElementConfig.textColor.ToRaylib());
                    break;
                case Clay_RenderCommandType.CLAY_RENDER_COMMAND_TYPE_IMAGE:
                    Texture2D texture =
                        *(Texture2D*)(command.config.imageElementConfig.imageData.swigCPtr
                            .Handle); // The most dangerous line of code I've ever written
                    Raylib.DrawTextureEx(texture, new Vector2(boundingBox.x, boundingBox.y), 0,
                        (boundingBox.x) / (boundingBox.y), Color.White);
                    break;
                case Clay_RenderCommandType.CLAY_RENDER_COMMAND_TYPE_SCISSOR_START:
                    Raylib.BeginScissorMode((int)Math.Round(boundingBox.x), (int)Math.Round(boundingBox.y),
                        (int)Math.Round(boundingBox.width), (int)Math.Round(boundingBox.height));
                    break;
                case Clay_RenderCommandType.CLAY_RENDER_COMMAND_TYPE_SCISSOR_END:
                    Raylib.EndScissorMode();
                    break;
                case Clay_RenderCommandType.CLAY_RENDER_COMMAND_TYPE_RECTANGLE:
                    var config = command.config.rectangleElementConfig;
                    if (config.cornerRadius.topLeft > 0)
                    {
                        float radius = (config.cornerRadius.topLeft * 2) /
                                       (float)((boundingBox.width > boundingBox.height)
                                           ? boundingBox.height
                                           : boundingBox.width);
                        Raylib.DrawRectangleRounded(
                            new Rectangle(boundingBox.x, boundingBox.y, boundingBox.width, boundingBox.height), radius,
                            8, config.color.ToRaylib());
                    }
                    else
                    {
                        Raylib.DrawRectangle((int)boundingBox.x, (int)boundingBox.y, (int)boundingBox.width,
                            (int)boundingBox.height, config.color.ToRaylib());
                    }

                    break;
                case Clay_RenderCommandType.CLAY_RENDER_COMMAND_TYPE_BORDER:
                    Clay_BorderElementConfig borderConfig = command.config.borderElementConfig;
                    if (borderConfig.left.width > 0)
                    {
                        Raylib.DrawRectangle((int)boundingBox.x, (int)boundingBox.y,
                            (int)borderConfig.left.width, (int)boundingBox.height,
                            borderConfig.left.color.ToRaylib());
                    }

                    if (borderConfig.right.width > 0)
                    {
                        Raylib.DrawRectangle(
                            (int)(boundingBox.x + boundingBox.width - borderConfig.right.width),
                            (int)boundingBox.y, (int)borderConfig.right.width, (int)boundingBox.height,
                            borderConfig.right.color.ToRaylib());
                    }

                    if (borderConfig.top.width > 0)
                    {
                        Raylib.DrawRectangle((int)boundingBox.x, (int)boundingBox.y, (int)boundingBox.width,
                            (int)borderConfig.top.width, borderConfig.top.color.ToRaylib());
                    }

                    if (borderConfig.bottom.width > 0)
                    {
                        Raylib.DrawRectangle((int)boundingBox.x,
                            (int)(boundingBox.y + boundingBox.height - borderConfig.bottom.width),
                            (int)boundingBox.width, (int)borderConfig.bottom.width,
                            borderConfig.bottom.color.ToRaylib());
                    }

                    if (borderConfig.cornerRadius.topLeft > 0)
                    {
                        Raylib.DrawRing(
                            new Vector2(boundingBox.x + borderConfig.cornerRadius.topLeft,
                                boundingBox.y + borderConfig.cornerRadius.topLeft), borderConfig.cornerRadius.topLeft,
                            borderConfig.cornerRadius.topLeft + borderConfig.top.width, 0, 90, 0,
                            borderConfig.top.color.ToRaylib());
                    }

                    if (borderConfig.cornerRadius.topRight > 0)
                    {
                        Raylib.DrawRing(
                            new Vector2(boundingBox.x + boundingBox.width - borderConfig.cornerRadius.topRight,
                                boundingBox.y + borderConfig.cornerRadius.topRight), borderConfig.cornerRadius.topRight,
                            borderConfig.cornerRadius.topRight + borderConfig.top.width, 90, 180, 0,
                            borderConfig.top.color.ToRaylib());
                    }

                    if (borderConfig.cornerRadius.bottomLeft > 0)
                    {
                        Raylib.DrawRing(
                            new Vector2(boundingBox.x + borderConfig.cornerRadius.bottomLeft,
                                boundingBox.y + boundingBox.height - borderConfig.cornerRadius.bottomLeft),
                            borderConfig.cornerRadius.bottomLeft,
                            borderConfig.cornerRadius.bottomLeft + borderConfig.bottom.width, 270, 360, 0,
                            borderConfig.bottom.color.ToRaylib());
                    }

                    if (borderConfig.cornerRadius.bottomRight > 0)
                    {
                        Raylib.DrawRing(
                            new Vector2(boundingBox.x + boundingBox.width - borderConfig.cornerRadius.bottomRight,
                                boundingBox.y + boundingBox.height - borderConfig.cornerRadius.bottomRight),
                            borderConfig.cornerRadius.bottomRight,
                            borderConfig.cornerRadius.bottomRight + borderConfig.bottom.width, 180, 270, 0,
                            borderConfig.bottom.color.ToRaylib());
                    }

                    break;

                case Clay_RenderCommandType.CLAY_RENDER_COMMAND_TYPE_CUSTOM:
                    Clay_CustomElementConfig customConfig = command.config.customElementConfig;
                    // TODO: implement custom rendering
                    break;

                default:
                    Console.WriteLine($"Unknown command type: {command.commandType}");
                    break;
            }
        }
    }
}