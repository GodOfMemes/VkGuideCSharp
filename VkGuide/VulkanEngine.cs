using Hexa.NET.SDL2;
using Vortice.Vulkan;

namespace VkGuide;

public unsafe class VulkanEngine
{
    public bool IsInitialized;
    public int FrameNumber;

    public VkExtent2D WindowExtent = new(1700, 900);

    public SDLWindow* Window;


    public void Init()
    {
        SDL.Init(SDL.SDL_INIT_VIDEO);
        
        
        Window = SDL.CreateWindow("Vulkan Engine", 
            (int)SDL.SDL_WINDOWPOS_UNDEFINED_MASK, 
            (int)SDL.SDL_WINDOWPOS_UNDEFINED_MASK, 
            (int)WindowExtent.width, 
            (int)WindowExtent.height, 
            (uint)SDLWindowFlags.Vulkan);
        
        IsInitialized = true;
    }

    public void Cleanup()
    {
        if (IsInitialized)
        {
            SDL.DestroyWindow(Window);
            SDL.Quit();
        }
    }

    public void Run()
    {
        SDLEvent e = default;
        bool quit = false;

        while (!quit)
        {
            while (SDL.PollEvent(ref e) != 0)
            {
                switch ((SDLEventType)e.Type)
                {
                    case SDLEventType.Quit:
                        quit = true;
                        break;
                }
            }
            
            Draw();
        }
    }

    private void Draw()
    {
        
    }
}