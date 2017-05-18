# Installation Guide

## Requirement

This SDK requires the Target Framework version is later than 3.5.   

## Installation

### Install from source code

$ git clone git@github.com:yunify/qingstor-sdk-net.git

Open the source code by Visual Studio 2013 or later.

### Reference DLL

You can download the DLL from [here](https://github.com/yunify/qingstor-sdk-net/releases), and add it to your project. 
Because the SDK depends on Newtonsoft.Json.dll, you must install it for your version:

Install-Package Newtonsoft.Json 

### Install from NuGet

Search QingStor_SDK_NET45(the target framework is 4.5) that your version by NuGet Package Manager, or Input command line in the console:

Install-Package QingStor_SDK_NET45
