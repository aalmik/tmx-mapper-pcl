using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Windows.Storage;
using System.Threading.Tasks;
using System;
using TmxMapperPCL;
namespace MonoGameRenderMap
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Map levelMap;
        
       
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here                              
            graphics.SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected async override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            // TODO: use this.Content to load your game content here
            StorageFile file = await GetStorageFile(@"Levels\level1.xml");
            levelMap = await Map.Load(file);

            ResetGame();
        }


        private void ResetGame()
        {
            // Render map.
            int tiles = levelMap.Layers[0].Data.Tiles.Count;
            for (int i = 0; i < tiles; i++)
            {
                DataTile tile = levelMap.Layers[0].Data.Tiles[i];
                if (tile.GID != 0)
                {
                    // Get tileset by tile's GID.
                    TileSet tileSet = levelMap.GetTileSet(tile.GID);

                    // Get image from tileset
                    Image image = tileSet.GetTileSetImage(tile.GID);

                    // Get target image location
                    Image targetImage = levelMap.GetTileTarget(levelMap.Layers[0], i);

                    // Defining tileset image and target image.
                    Rectangle sourceRect = new Rectangle(image.X, image.Y, tileSet.TileWidth, tileSet.TileHeight);
                    Rectangle targetRect = new Rectangle(targetImage.X, targetImage.Y, tileSet.TileWidth, tileSet.TileHeight);
                    
                    // TODO: Create SpriteObject and add it to the game objects. Draw the complete map.
                }
            }

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);          
            // TODO: Add your drawing code here                      
         
            base.Draw(gameTime);
        }


        private async Task<StorageFile> GetStorageFile(string fileName)
        {
            StorageFolder installedLocation = Windows.ApplicationModel.Package.Current.InstalledLocation;            
            return await installedLocation.GetFileAsync(fileName);
        }
    }
}
