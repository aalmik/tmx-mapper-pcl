# Tiled map file parser for Windows universal apps
Tmx-Mapper-PCL is C# library for parsing Tiled map editor's TMX files.
This library is intended for use with Monogame framework and Windows runtime Universal applications.

## Usage:
```
using System;
using System.Threading.Tasks;
using TmxMapperPCL;
....

private async Task<StorageFile> GetStorageFile()
        {
            StorageFolder installedLocation = Windows.ApplicationModel.Package.Current.InstalledLocation;
            return await installedLocation.GetFileAsync("Levels\\GameMap.xml");
        }
        
protected async override void LoadContent()
        {
            StorageFile file = await GetStorageFile();
            Map levelMap = await Map.Load(file);
        }
```

## Change Log:

tmx-mapper-pcl 1.1.0
 - Supports for Tiled Map TMX format 0.10.0.
 - Published Nuget package TmxMapperPCL.1.1.0.nupkg

tmx-mapper-pcl 1.0.0
- Source code uploaded 
- Added support for basic TMX map elements
