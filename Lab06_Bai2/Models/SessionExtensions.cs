using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace Lab06_Bai2.Models
{
    public static class SessionExtensions
    {
        // Lưu đối tượng vào Session dưới dạng JSON string
        public static void SetObject<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        // Lấy đối tượng từ Session và deserialize thành kiểu dữ liệu tương ứng
        public static T? GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }
    }
}
