﻿# Clay C# 

This is a simple (mostly autogenerated) C# wrapper for the clay library.
The Clay.cs file holds the macros, that could not be autogenerated by swig, unfortunately they had to be changed a little.  

In ./Native you can find the clay.h file, and the swig.i file.  Read the markdown file in that directory for more information on how to compile the swig.i file.

ClayHelpers.cs has some helper functions, that are useful for working with the clay library.  
UnsafeUtils.cs has some unsafe functions, that are useful for working with the clay library.