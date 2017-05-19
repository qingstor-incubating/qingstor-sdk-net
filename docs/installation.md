# Installation Guide

## Requirement

This SDK requires the version of .NET Framework is newer than 3.5.

## Installation

Firstly, you should choose the right version for your .NET Framework, for example,
assuming the version of your .NET Framework is 4.5, then you should have *QINGSTOR_SDK_NET45* installed.

### Install from source code

```
  $ git clone https://github.com/yunify/qingstor-sdk-net.git
```

Open the source code by Visual Studio 2013 or later.

### Reference DLL

You can download the DLL from [here](https://github.com/yunify/qingstor-sdk-net/releases), and add it to your project.
Because the SDK depends on Newtonsoft.Json.dll, you must install it for your version with:

```
  Install-Package Newtonsoft.Json
```

### Install from NuGet

You can either install the SDK by searching the right version in NuGet Package Manager,
or with the below command line in the console:

```
  Install-Package QingStor_SDK_NET45
```
