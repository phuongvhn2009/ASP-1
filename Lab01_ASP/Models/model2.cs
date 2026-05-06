namespace Lab01_ASP.Models
{
    public class model2
    {
        
        public string SubName { get; set; }
        public string Image { get; set; }

        
        public static List<model2> GetMajors()
        {
            return new List<model2> 
            {
                new model2 { SubName = "Thiết kế đồ họa", Image = "/img/images/image1.png" },
                new model2 { SubName = "Lập trình di động", Image = "/img/images/image2.png" },
                new model2 { SubName = "Thiết kế Website", Image = "/img/images/image3.png" },
                new model2 { SubName = "Ứng dụng phần mềm", Image = "/img/images/image4.png" },
                new model2 { SubName = "An toàn thông tin", Image = "/img/images/image5.png" },
                new model2 { SubName = "Trí tuệ nhân tạo (AI)", Image = "/img/images/image6.png" },
                new model2 { SubName = "Quản trị mạng", Image = "/img/images/image7.png" },
                new model2 { SubName = "Marketing kỹ thuật số", Image = "/img/images/image8.png" },
                new model2 { SubName = "Phát triển Game", Image = "/img/images/image9.png" },
                new model2 { SubName = "Phân tích dữ liệu", Image = "/img/images/image10.png" }
            };
        }
    }
}