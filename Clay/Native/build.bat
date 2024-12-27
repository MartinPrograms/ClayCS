
REM This script will build the swig wrapper for the clay library
@echo off

if exist Swiggin rmdir /s /q Swiggin
mkdir Swiggin

copy swig.i Swiggin
copy clay.h Swiggin

cd Swiggin

mkdir output
mkdir cpp

swig -csharp -c++ -outdir output -o cpp/ClayLibrary.cpp swig.i

copy ..\clay.h cpp

echo "Prepared swig"

cd cpp

echo COMPILE USING MSVC OR OTHER COMPILER
explorer .