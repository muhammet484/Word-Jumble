﻿
using System.Collections.Generic;

class WordsClass
{
    public string Name;
    public List<string> Words;

    WordsClass(string name, List<string> words)
    {
        this.Name = name;
        this.Words = words;
    }

    public static WordsClass Turkish = new WordsClass(
        "Turkish",
        new List<string> {"yürü", "koş", "zıpla", "ye", "iç", "oyna", "oku", "yaz", "çalış", "seyahat", "uyku", "konuş", "dinle", "gör", "duy", "dokun", "tat", "koklamak", "düşünmek", "hissetmek", "gülmek", "sevmek", "sevmek", "sevmemek", "anlamak", "bilmek", "öğren", "öğret", "unut", "hatırla", "iste", "ver", "al", "kullan", "bul", "tut", "yap", "kır", "söyle", "gel", "al", "ev", "ev", "oda", "yatak", "mutfak", "banyo", "tuvalet", "salon", "kapı", "pencere", "araba", "bisiklet", "otobüs", "tren", "uçak", "gemi", "kitap", "kalem", "kağıt", "bilgisayar", "telefon", "televizyon", "müzik", "yiyecek", "içecek", "giyim", "ayakkabı", "şapka", "şemsiye", "güneş", "ay", "yıldız", "gökyüzü", "yer", "ağaç", "çiçek", "bitki", "hayvan", "kuş", "balık", "böcek", "yılan", "kaplan", "aslan", "fil", "zürafa", "zebra", "antilop", "geyik", "kurt", "tilki", "rakun", "sincap", "dağ", "tepe", "vadi", "çöl", "orman", "orman", "meyve", "elma", "muz", "portakal", "çilek", "üzüm", "ahududu", "böğürtlen", "karpuz", "kavun", "şeftali", "armut", "erik", "limon", "lime", "greyfurt", "mandalina", "nar", "kivi", "mango", "ananas", "fındık", "fıstık", "badem", "kaju", "fıstık", "ceviz", "ceviz", "fındık", "kestane", "ekmek", "bisküvi", "kek", "börek", "kurabiye", "kraker", "tahıl", "pirinç", "erişte", "spagetti", "lazanya", "pizza", "burger", "sandviç", "çorba", "güveç", "köri", "ramen", "suşi", "sığır", "tavuk", "domuz", "tofu", "yumurta", "süt", "peynir", "süt", "yoğurt", "tereyağı", "krema", "kahve", "çay", "soda", "su", "köpek", "kedi", "güneş", "araba", "fincan", "masa", "bilgisayar", "fare", "klavye", "monitör", "televizyon", "telefon", "masa", "sandalye", "kitap", "kalem", "kağıt", "müzik", "film", "yiyecek", "içecek", "giyim", "ayakkabı", "şapka", "şemsiye", "yağmur", "kar", "bulut", "gökyüzü", "yer", "ağaç", "çiçek", "bitki", "hayvan", "kuş", "balık", "böcek", "yılan", "kaplan", "aslan", "fil", "zürafa", "zebra", "antilop", "geyik", "kurt", "tilki", "rakun", "sincap", "ev", "daire", "bina", "sokak", "yol", "köprü", "nehir", "göl", "okyanus", "ada", "dağ", "tepe", "vadi", "çöl", "orman", "orman", "ağaç", "elma", "muz", "portakal", "çilek", "üzüm", "ahududu", "böğürtlen", "karpuz", "kavun", "şeftali", "armut", "erik", "limon", "lime", "greyfurt", "mandalina", "nar", "kivi", "mango", "ananas", "fıstık", "badem", "kaju", "fıstık", "ceviz", "ceviz", "fındık", "kestane", "ekmek", "bisküvi", "kek", "turta", "kurabiye", "kraker", "tahıl", "pirinç", "erişte", "spagetti", "lazanya", "pizza", "burger", "sandviç", "çorba", "güveç", "acı", "köri", "ramen", "suşi", "tempura", "teriyaki", "tonkatsu", "udon", "gyudon", "shabu-shabu", "sukiyaki", "takoyaki", "yakiniku", "tavuk", "domuz", "tofu", "yumurta", "süt", "peynir", "süt", "yoğurt", "tereyağı", "krema", "kahve", "çay", "soda", "su", "limonata", "alkol", "bira", "şarap", "viski", "votka", "rom", "cin", "brendi", "konyak", "şampanya", "gömlek", "elbise", "etek", "şort", "mayo", "şapka", "şapka", "eldiven", "eşarp", "mont", "ceket", "yelek", "kazak", "blazer", "kravat", "papyon", "kemer", "ayakkabı", "çizme", "sandalet", "topuk", "terlik", "tren", "otobüs", "taksi", "araba"
                                   }
        );
    public static WordsClass English = new WordsClass(
        "English",
        new List<string> {
            "walk", "run", "jump", "eat", "drink", "play", "read", "write", "sing", "dance",    "work", "study", "travel", "sleep", "speak", "listen", "see", "hear", "touch", "taste",    "smell", "think", "feel", "laugh", "love", "hate", "like", "dislike", "understand", "know",    "learn", "teach", "forget", "remember", "help", "need", "want", "have", "give", "take",    "use", "find", "keep", "make", "break", "say", "come", "get",    "house", "home", "room", "bed", "kitchen", "bathroom", "toilet", "hall", "door", "window",    "car", "bike", "bus", "train", "airplane", "ship", "book", "pencil", "paper", "computer",    "phone", "television", "music", "food", "drink", "clothing", "shoe", "hat", "umbrella",    "sun", "moon", "star", "sky", "earth", "tree", "flower", "plant", "animal",    "bird", "fish", "insect", "snake", "tiger", "lion", "elephant", "giraffe", "zebra",    "antelope", "deer", "wolf", "fox", "raccoon", "squirrel", "mountain", "hill", "valley",    "desert", "jungle", "forest", "fruit", "apple", "banana", "orange", "strawberry", "grape",    "blueberry", "raspberry", "blackberry", "watermelon", "melon", "peach", "pear", "plum",    "lemon", "lime", "grapefruit", "tangerine", "pomegranate", "kiwi", "mango", "pineapple",    "coconut", "nut", "peanut", "almond", "cashew", "pistachio", "walnut", "pecan", "hazelnut",    "chestnut", "bread", "biscuit", "cake", "pie", "cookie", "cracker", "cereal", "rice",    "noodle", "spaghetti", "lasagna", "pizza", "burger", "sandwich", "soup", "stew", "chili",    "curry", "ramen", "sushi", "beef", "chicken", "pork", "tofu", "egg", "dairy",    "cheese", "milk", "yogurt", "butter", "cream", "coffee", "tea", "juice", "soda", "water",
            //above Words are simplier then below ones. also above Words are unique. belows are not unique
            "dog", "cat", "sun", "car", "cup", "desk", "computer", "mouse", "keyboard", "monitor", "television", "phone", "table", "chair", "book", "pen", "paper", "music", "movie", "food", "drink", "clothing", "shoe", "hat", "umbrella", "rain", "snow", "cloud",                   "sky", "earth", "tree", "flower", "plant", "animal", "bird", "fish", "insect",                   "snake", "tiger", "lion", "elephant", "giraffe", "zebra", "antelope", "deer",                   "wolf", "fox", "raccoon", "squirrel", "house", "apartment", "building", "street",                   "road", "bridge", "river", "lake", "ocean", "island", "mountain", "hill",                   "valley", "desert", "jungle", "forest", "tree", "apple", "banana", "orange",                   "strawberry", "grape", "blueberry", "raspberry", "blackberry", "watermelon",                   "melon", "peach", "pear", "plum", "lemon", "lime", "grapefruit", "tangerine",                   "pomegranate", "kiwi", "mango", "pineapple", "coconut", "peanut", "almond", "cashew",                   "pistachio", "walnut", "pecan", "hazelnut", "chestnut", "bread", "biscuit", "cake",                   "pie", "cookie", "cracker", "cereal", "rice", "noodle", "spaghetti", "lasagna",                   "pizza", "burger", "sandwich", "soup", "stew", "chili", "curry", "ramen", "sushi",                   "tempura", "teriyaki", "tonkatsu", "udon", "gyudon", "shabu-shabu", "sukiyaki",                   "takoyaki", "yakiniku", "beef", "chicken", "pork", "tofu", "egg", "dairy", "cheese",                   "milk", "yogurt", "butter", "cream", "coffee", "tea", "juice", "soda", "water",                   "lemonade", "smoothie", "alcohol", "beer", "wine", "whiskey", "vodka", "rum",                   "gin", "brandy", "cognac", "champagne", "jeans", "shirt", "dress", "skirt", "shorts",                   "swimwear", "hat", "cap", "gloves", "scarf", "coat", "jacket", "vest", "sweater",                   "blazer", "suit", "tie", "bowtie", "belt", "shoe", "sneaker", "boot", "sandal","heel", "flipflop", "slipper", "train", "bus", "taxi", "car"
        }
        ); 
    public static WordsClass German = new WordsClass(
        "German",
        new List<string> { "gehen", "laufen", "springen", "essen", "trinken", "spielen", "lesen", "schreiben", "singen", "tanzen", "arbeiten", "studieren", "reisen", "schlafen", "sprechen", "hören", "sehen", "hören", "berühren", "schmecken", "riechen", "denken", "fühlen", "lachen", "lieben", "hasen", "mögen", "verstehen", "wissen", "lernen", "lehren", "vergessen", "erinnern", "helfen", "brauchen", "wollen", "haben", "geben", "nehmen", "verwenden", "finden", "behalten", "machen", "sagen", "kommen", "bekommen", "Haus", "Zuhause", "Zimmer", "Bett", "Küche", "Badezimmer", "Toilette", "Flur", "Tür", "Fenster", "Auto", "Fahrrad", "Bus", "Zug", "Flugzeug", "Schiff", "Buch", "Stift", "Papier", "Computer", "Telefon", "Fernseher", "Musik", "Essen", "Trinken", "Kleidung", "Schuh", "Hut", "Regenschirm", "Sonne", "Mond", "Stern", "Himmel", "Erde", "Baum", "Blume", "Pflanze", "Tier", "Vogel", "Fisch", "Insekt", "Schlange", "Tiger", "Löwe", "Elefant", "Giraffe", "Zebra", "Antilope", "Reh", "Wolf", "Fuchs", "Waschbär", "Eichhörnchen", "Berg", "Hügel", "Tal", "Wüste", "Dschungel", "Wald", "Obst", "Apfel", "Banane", "Orange", "Erdbeere", "Traube", "Blaubeere", "Himbeere", "Wassermelone", "Melone", "Pfirsich", "Birne", "Pflaume", "Zitrone", "Limette", "Grapefruit", "Mandarine", "Granatapfel", "Kiwi", "Mango", "Ananas", "Kokosnuss", "Nuss", "Erdnuss", "Mandel", "Cashew", "Pistazie", "Walnuss", "Pekannuss", "Haselnuss", "Kastanie", "Brot", "Keks", "Kuchen", "Torte", "Keks", "Cracker", "Ceralien", "Reis", "Nudel", "Spaghetti", "Lasagne", "Pizza"
                                                                                        }
        );

}