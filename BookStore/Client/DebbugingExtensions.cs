using System.Text.Json;

namespace BookStore.Client
{
    public static class DebbugingExtensions
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true};

        public static string ToJoin(this object obj) => JsonSerializer.Serialize(obj, options);
    }
}
