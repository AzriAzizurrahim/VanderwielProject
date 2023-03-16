using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VandewieleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VandewieleController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Vandewiele>>> GetVandewiele()
        {
            return new List<Vandewiele>
            {
                new Vandewiele
                {
                    //Name = "Bruno Mars",
                    //FirstName= "Bruno",
                    //LastName= "Mars",
                    //Place= "Washington"
                     id= 1,
                     Name = "Nike Air Max Pulse",
                     Price= 123.95,
                     Description= "Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday",
                     Category= "men's Shoes",
                     Image= "https://static.nike.com/a/images/t_PDP_1728_v1/9dbd80b5-889e-4558-9949-1f506654fb23/air-max-pulse-shoes-QShhG8.png",
                },

                new Vandewiele
                {
                     id= 2,
                     Name = "Ultra Adidas 4D Shoes",
                     Price= 1080.00,
                     Description= "These running shoes provide comfort and support for any distance. They have a breathable knit upper that hugs the foot and a Boost",
                     Category= "men's Shoes",
                     Image= "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/fefbdd4daa594035a3bfaf2a01600a3d_9366/Ultra_adidas_4D_Shoes_White_HP9735_01_standard.jpg"
                },

                new Vandewiele
                {
                     id= 3,
                     Name = "Air Jordan 1 Mid SE",
                     Price= 599.00,
                     Description= "Premium materials and accents give modern expression to an all-time favourite.",
                     Category= "men's Shoes",
                     Image= "https://static.nike.com/a/images/t_PDP_1728_v1/ca113e5f-2165-476a-8dcf-ce7a0d85356c/air-jordan-1-mid-se-shoes-CQ6f9G.png"
                },

                new Vandewiele
                {
                     id= 4,
                     Name = "Ultraboost 1.0 Shoes",
                     Price= 829.00,
                     Description= "Responsive running shoes, madein part with parley ocean placstic.",
                     Category= "women's Shoes",
                     Image= "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/b76e96951ef4469db67caf2c012013b9_9366/Ultraboost_1.0_Shoes_Brown_HQ2195_01_standard.jpg"
                },

                new Vandewiele
                {
                    id= 5,
                     Name = "Air Jordan 2 Retro",
                     Price= 509.00,
                     Description= "With premium leather and an Air-Sole unit underfoot, this throwback serves up the ultimate combo of wearability and style.",
                     Category= "kids's Shoes",
                     Image= "https://static.nike.com/a/images/t_PDP_1728_v1/4741395d-5c3f-4e8f-899a-627b45919a52/air-jordan-2-retro-older-shoes-qDrFvg.png"
                },
                new Vandewiele
                {
                    id= 6,
                     Name = "Forum Low The Grinch Shoes",
                     Price= 459.00,
                     Description= "Shoes that tell the story of Dr.Seuss",
                     Category= "kids's Shoes",
                     Image= "https://assets.adidas.com/images/h_840,f_auto,q_auto,fl_lossy,c_fill,g_auto/6d1758ed8e114cc390f4af5800adec75_9366/Forum_Low_The_Grinch_Shoes_Multi_ID4315_01_standard.jpg"
                }

            };
        }
    }
}
