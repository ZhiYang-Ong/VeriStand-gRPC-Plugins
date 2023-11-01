# VeriStand-gRPC-Plugins

VeriStand Engine only supports streaming data in DBL. This repo provides editor plugins that allow users to read and write strings using gRPC.
Currently, only gRPC Clients on editor is provided. The gRPC Server, running as a Custom Device on the VeriStand Engine will be updated in the future.

## Plug-and-plug Guide
### Editor Plugins
1. Copy "\build\Custom UI Manager Controls" to "C:\Users\Public\Documents\National Instruments\NI VeriStand 2020\Custom UI Manager Controls"
2. Launch VeriStand and locate the new palette in the screen document with two droppable controls.

## Getting Started
To be updated.

### Dependencies
* [gRPC Support for LabVIEW v1.0.1.1](https://github.com/ni/grpc-labview/releases/tag/v1.0.1.1))
* .NET - .NET 4.6.2 installed to your local machine. VeriStand is built against this version.
* Compiler - Any C# editor and compiler that supports .NET 4.6.2. These codes were created with Visual Studio 2015.

### Reference
* [VeriStand Editor Plugin Examples](https://github.com/ni/veristand-editor-plugin-examples)
* [gRPC Support for LabVIEW](https://github.com/ni/grpc-labview/)

## Support
This code is provided as is. For any feedbacks, please create a new [issue ticket](https://github.com/ZhiYang-Ong/VeriStand-gRPC-Plugins/issues).