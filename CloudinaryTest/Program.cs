using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace CloudinaryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var cloudinary = new Cloudinary( new Account(
                "itstepfac",
                "682628857924842",
                "BdOANJaher8MufO5HNvPQE_Rc_o"));
            //cloudinary.Api.UrlImgUp.Transform(new Transformation()
            //  .Width(400).Height(400).Gravity("face").Radius("max").Crop("crop").Chain()
            //  .Width(200).Crop("scale")).BuildImageTag("lady.jpg");

            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(@"C:\Users\УринбасаровД\Downloads\actor.jpg"),
                PublicId = "sample_id5",
                Transformation = new Transformation().Width(200).Height(200).Gravity("face").Radius("max").Effect("grayscale").Crop("crop").Chain()
                .Width(100).Crop("scale")
                //EagerTransforms = new List<Transformation>()
                //  {
                //    new Transformation().Width(200).Height(200).Crop("thumb").Gravity("face").
                //      Radius(20).Effect("sepia"),
                //    //new Transformation().Width(100).Height(150).Crop("fit").FetchFormat("png")
                //  },
                //Tags = "special, for_homepage"

            };

            var uploadResult = cloudinary.Upload(uploadParams);
            //Console.ReadLine();

        }
    }
}
