namespace FoodDiary.Models
{
    class FillDatabase
    {
        public static void InsertDefault(SQLite.SQLiteAsyncConnection d)
        {
            d.InsertAsync(new Foods
            {
                Name = "Chléb",
                Calory = 244,
                Carbohydrates = 45,
                Proteins = 8,
                Fats = 1,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Rohlík bílý",
                Calory = 310,
                Carbohydrates = 57,
                Proteins = 10,
                Fats = 4,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Kaiserka",
                Calory = 262,
                Carbohydrates = 43,
                Proteins = 10,
                Fats = 5,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Houska obyčejná",
                Calory = 288,
                Carbohydrates = 60,
                Proteins = 8,
                Fats = 1,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Toustový chléb světlý",
                Calory = 264,
                Carbohydrates = 51,
                Proteins = 10,
                Fats = 2,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Bageta celozrnná",
                Calory = 257,
                Carbohydrates = 42,
                Proteins = 11,
                Fats = 4,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Bageta",
                Calory = 248,
                Carbohydrates = 50,
                Proteins = 9,
                Fats = 1,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Kobliha s marmeládou",
                Calory = 361,
                Carbohydrates = 50,
                Proteins = 6,
                Fats = 15,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Loupák",
                Calory = 353,
                Carbohydrates = 55,
                Proteins = 10,
                Fats = 10,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Donut čokoládový",
                Calory = 430,
                Carbohydrates = 58,
                Proteins = 4,
                Fats = 20,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Vánočka s hrozinkami",
                Calory = 329,
                Carbohydrates = 59,
                Proteins = 8,
                Fats = 6,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Bábovka",
                Calory = 381,
                Carbohydrates = 60,
                Proteins = 7,
                Fats = 12,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Muffin čokoládový",
                Calory = 404,
                Carbohydrates = 50,
                Proteins = 5,
                Fats = 20,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Eidam",
                Calory = 263,
                Carbohydrates = 1,
                Proteins = 30,
                Fats = 15,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Gouda",
                Calory = 344,
                Carbohydrates = 1,
                Proteins = 26,
                Fats = 26,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Cottage cheese",
                Calory = 109,
                Carbohydrates = 3,
                Proteins = 11,
                Fats = 6,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Hermelín",
                Calory = 329,
                Carbohydrates = 2,
                Proteins = 18,
                Fats = 28,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Lučina",
                Calory = 270,
                Carbohydrates = 2,
                Proteins = 7,
                Fats = 26,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Olomoucé tvarůžky",
                Calory = 129,
                Carbohydrates = 3,
                Proteins = 28,
                Fats = 0.5,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Tavený sýr",
                Calory = 259,
                Carbohydrates = 5,
                Proteins = 9,
                Fats = 23,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Tavený sýr se šunkou",
                Calory = 237,
                Carbohydrates = 8,
                Proteins = 8,
                Fats = 19,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Žervé",
                Calory = 204,
                Carbohydrates = 6,
                Proteins = 10,
                Fats = 16,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Palouček",
                Calory = 248,
                Carbohydrates = 2,
                Proteins = 5,
                Fats = 24,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Řecký jogurt bílý",
                Calory = 58,
                Carbohydrates = 4,
                Proteins = 10,
                Fats = 0.3,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Selský jogurt bílý",
                Calory = 67,
                Carbohydrates = 4,
                Proteins = 4,
                Fats = 4,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Vejce",
                Calory = 151,
                Carbohydrates = 0.94,
                Proteins = 12,
                Fats = 11,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Vejce na tvrdo",
                Calory = 152,
                Carbohydrates = 1,
                Proteins = 13,
                Fats = 11,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Míchaná vejce",
                Calory = 166,
                Carbohydrates = 2,
                Proteins = 12,
                Fats = 12,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Volské oko",
                Calory = 194,
                Carbohydrates = 1,
                Proteins = 14,
                Fats = 15,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Tvaroh  odtučněný",
                Calory = 64,
                Carbohydrates = 9,
                Proteins = 12,
                Fats = 0.3,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Tvaroh polotučný",
                Calory = 91,
                Carbohydrates = 4,
                Proteins = 10,
                Fats = 4,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Tvaroh tučný",
                Calory = 130,
                Carbohydrates = 4,
                Proteins = 9,
                Fats = 9,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Mléko polotučné",
                Calory = 47,
                Carbohydrates = 5,
                Proteins = 3,
                Fats = 2,
                Liquid = true
            });
            d.InsertAsync(new Foods
            {
                Name = "Mléko plnotučné",
                Calory = 64,
                Carbohydrates = 5,
                Proteins = 3,
                Fats = 4,
                Liquid = true
            });
            d.InsertAsync(new Foods
            {
                Name = "Smetana na vaření 12%",
                Calory = 134,
                Carbohydrates = 4,
                Proteins = 3,
                Fats = 12,
                Liquid = true
            });
            d.InsertAsync(new Foods
            {
                Name = "Smetana ke šlehání 33%",
                Calory = 294,
                Carbohydrates = 3,
                Proteins = 2,
                Fats = 31,
                Liquid = true
            });
            d.InsertAsync(new Foods
            {
                Name = "Zakysaná smetana",
                Calory = 134,
                Carbohydrates = 4,
                Proteins = 3,
                Fats = 12,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Kuřecí stehno pečené",
                Calory = 145,
                Carbohydrates = 0,
                Proteins = 20,
                Fats = 7,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Kuřecí řízek",
                Calory = 310,
                Carbohydrates = 15,
                Proteins = 22,
                Fats = 18,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Krůtí prsa",
                Calory = 107,
                Carbohydrates = 0.1,
                Proteins = 20,
                Fats = 3,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Vepřové maso pečené",
                Calory = 174,
                Carbohydrates = 0,
                Proteins = 30,
                Fats = 6,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Vepřový řízek",
                Calory = 411,
                Carbohydrates = 15,
                Proteins = 20,
                Fats = 30,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Hovězí steak",
                Calory = 125,
                Carbohydrates = 0,
                Proteins = 20,
                Fats = 5,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Hovězí burger s bulkou",
                Calory = 349,
                Carbohydrates = 27,
                Proteins = 22,
                Fats = 17,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Dušená šunka",
                Calory = 91,
                Carbohydrates = 2,
                Proteins = 14,
                Fats = 3,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Salám Vysočina",
                Calory = 440,
                Carbohydrates = 2,
                Proteins = 19,
                Fats = 40,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Slanina anglická",
                Calory = 403,
                Carbohydrates = 0.08,
                Proteins = 11,
                Fats = 40,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Klobása moravská",
                Calory = 283,
                Carbohydrates = 2,
                Proteins = 14,
                Fats = 24,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Tuňák",
                Calory = 103,
                Carbohydrates = 0,
                Proteins = 24,
                Fats = 0.7,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Losos",
                Calory = 196,
                Carbohydrates = 0,
                Proteins = 22,
                Fats = 12,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Rybí filé",
                Calory = 207,
                Carbohydrates = 1,
                Proteins = 16,
                Fats = 15,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "kapr smažený",
                Calory = 237,
                Carbohydrates = 7,
                Proteins = 25,
                Fats = 12,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Jablko",
                Calory = 63,
                Carbohydrates = 13,
                Proteins = 0.37,
                Fats = 0.4,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Hruška",
                Calory = 58,
                Carbohydrates = 13,
                Proteins = 0.44,
                Fats = 0.33,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Banán",
                Calory = 94,
                Carbohydrates = 22,
                Proteins = 1,
                Fats = 0.2,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Meruňky",
                Calory = 55,
                Carbohydrates = 12,
                Proteins = 0.7,
                Fats = 0.13,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Mandarinky",
                Calory = 57,
                Carbohydrates = 12,
                Proteins = 0.72,
                Fats = 0.3,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Borůvky",
                Calory = 44,
                Carbohydrates = 8,
                Proteins = 1,
                Fats = 0.6,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Švestky",
                Calory = 50,
                Carbohydrates = 10,
                Proteins = 0.5,
                Fats = 0.3,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Hrozny bílé",
                Calory = 80,
                Carbohydrates = 18,
                Proteins = 0.7,
                Fats = 0.3,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Maliny",
                Calory = 73,
                Carbohydrates = 13,
                Proteins = 1,
                Fats = 0.58,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Jahody",
                Calory = 34,
                Carbohydrates = 6,
                Proteins = 0.79,
                Fats = 0.37,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Ananas",
                Calory = 58,
                Carbohydrates = 13,
                Proteins = 0.49,
                Fats = 0.19,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Pomeranč",
                Calory = 50,
                Carbohydrates = 11,
                Proteins = 0.92,
                Fats = 0.22,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Broskev",
                Calory = 46,
                Carbohydrates = 10,
                Proteins = 0.9,
                Fats = 0.2,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Jahodová marmeláda",
                Calory = 258,
                Carbohydrates = 64,
                Proteins = 0.5,
                Fats = 0.3,
                Liquid = false
            });
            d.InsertAsync(new Foods
            {
                Name = "Višňová marmeláda",
                Calory = 264,
                Carbohydrates = 64,
                Proteins = 0.56,
                Fats = 0.22,
                Liquid = false
            }); ;
        }
    }
}
