Tmx-Mapper-PCL is C# library for parsing Tiled map editor's TMX files.
This library is intended for use with Monogame framework and Windows runtime Universal applications.

Usage:
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
