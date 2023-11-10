# VeriStand-gRPC-Plugins

VeriStand Engine only supports streaming data in DBL. This repo provides editor plugins that allow users to read and write strings using gRPC.

Due to internal naming conflicts issue, the gRPC Data Server Custom Device was compiled into a packed library (PPL). Hence the first available version for gRPC Plugins is VeriStand 2021.

## Plug-and-plug Guide
### Editor Plugins
1. Copy "\build\Custom UI Manager Controls" to "C:\Users\Public\Documents\National Instruments\NI VeriStand 2021\Custom UI Manager Controls"
2. Launch VeriStand and locate the new palette in the screen document with two droppable controls.

### gRPC Data Server Custom Device
1. Copy "\build\gRPC Data Server" to "C:\Users\Public\Documents\National Instruments\NI VeriStand 2021\Custom Devices"
2. Add a new gRPC Data Server in the system definition file.

### Example VeriStand Project
1. An example project "grpc-example" has been provided to demonstrate how gRPC server can be deployed to the VeriStand Engine as a custom device.
2. You can read/write the data in the gRPC server either by (a) modify gRPC Data Server or (b) use gRPC Client API in your own custom device, as shown in the "example-grpc-client-custom-device\example-grpc-client-custom-device"

## Note
### Known caveats
1. This project has only been tested on Windows. To run it on Linux RT, copy "C:\Users\Public\Documents\National Instruments\NI VeriStand 2021\Custom UI Manager Controls\Libraries\LinuxRT\liblabview_grpc_server.so" to "/home/lvuser/natinst/bin/liblabview_grpc_server.so" on the Linux RT target using FileZilla.
2. The channel names configured for gRPC channels are not stored to the .nivsscr file and will be lost when VeriStand closes. 

### Dependencies
* [gRPC Support for LabVIEW v1.0.1.1](https://github.com/ni/grpc-labview/releases/tag/v1.0.1.1))
* .NET - .NET 4.6.2 installed to your local machine. VeriStand is built against this version.
* Compiler - Any C# editor and compiler that supports .NET 4.6.2. These codes were created with Visual Studio 2015.

### Reference
* [VeriStand Editor Plugin Examples](https://github.com/ni/veristand-editor-plugin-examples)
* [gRPC Support for LabVIEW](https://github.com/ni/grpc-labview/)

## Support
This code is provided as is. For any feedbacks, please create a new [issue ticket](https://github.com/ZhiYang-Ong/VeriStand-gRPC-Plugins/issues).
