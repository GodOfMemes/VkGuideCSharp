using VkGuide;

static class Program
{
    static void Main(string[] args)
    {
        VulkanEngine engine = new();
        engine.Init();
        engine.Run();
        engine.Cleanup();
    }
}