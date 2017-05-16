# Installation Guide

## Install from source code

1. Clone source code

```bash
git clone git@github.com:yunify/qingstor-sdk-csharp.git
```

2. Add it to Project
Open the source code with Visual Studio 2013 or later than the version, add QingStor_SDK_CSharp project to your project by References(References->Add Reference).

## Modify project properties
In your project, add the properties that Post-build Event Command Line(properties->Build Events->Post-build Event Command Line):
$(SolutionDir)CopyFile.bat $(Configuration) $(SolutionDir)

then, modify the CopyFile.bat for your project output path.