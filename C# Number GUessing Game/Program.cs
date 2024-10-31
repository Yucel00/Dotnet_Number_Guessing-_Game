//Turkish is below
//English  

Random random = new Random();
int number = random.Next(1, 101); // Generates a random number between 1 and 100.

var attempts = 5; // Total number of attempts
var guessCount = 1; // Start count from 1
Console.WriteLine("We've thought of a number, try to guess it!"); // Message to the player.

while (true) // Start an infinite loop
{
    Console.Write($"{guessCount}. Guess>> "); // Prompt the user for a guess
    guessCount++; // Increment guess count
    var guess = Convert.ToInt32(Console.ReadLine()); // Read user's guess
    attempts--; // Decrease attempt count after each guess

    if (attempts == 0) // When attempts run out
    {
        Console.WriteLine($"Out of attempts! The number was {number}."); // Notify the player they lost
        break; // Exit the loop
    }
    else
    {
        if (guess == number) // If the guess is correct
        {
            Console.WriteLine($"Congratulations! You won, the number was {number}."); // Success message
            break; // Exit the loop
        }
        else if (guess < number) // If the guessed number is too low
        {
            Console.WriteLine($"A bit higher! Remaining attempts: {attempts}"); // Guide message
            continue; // Continue to the next iteration of the loop
        }
        else // If the guessed number is too high
        {
            Console.WriteLine($"A bit lower! Remaining attempts: {attempts}"); // Guide message
            continue; // Continue to the next iteration of the loop
        }
    }
}

//Turkish
// Random random = new Random();

int sayi = random.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı oluşturuyoruz.

var sayac = 5; // Toplam 5 tahmin hakkı
var deneme = 1; // İlk deneme sayısını 1 olarak ayarlıyoruz
Console.WriteLine("Aklimizdan Bir Sayi Tuttuk Hadi Bil"); // Oyuncuya bilgi veriyoruz.

while (true) // Sonsuz bir döngü başlatıyoruz
{
    Console.Write($"{deneme}.Tahmin>>"); // Kullanıcıdan tahmin istiyoruz
    deneme++; // Deneme sayısını artırıyoruz
    var tahmin = Convert.ToInt32(Console.ReadLine()); // Kullanıcı tahminini okuyoruz
    sayac--; // Her tahmin sonrası tahmin hakkını bir azaltıyoruz

    if (sayac == 0) // Tahmin hakkı bittiğinde
    {
        Console.WriteLine($"Tahmin Hakkin Doldu Sayi {sayi} idi "); // Oyuncuya kaybettiğini söylüyoruz
        break; // Döngüden çıkıyoruz
    }
    else
    {
        if (tahmin == sayi) // Kullanıcı doğru tahmini yaparsa
        {
            Console.WriteLine($"Tebrikler Kazandin Sayi {sayi} idi "); // Kazanma mesajı
            break; // Döngüden çıkıyoruz
        }
        else if (tahmin < sayi) // Tahmin edilen sayı küçükse
        {
            Console.WriteLine($"Biraz Daha Arttir Kalan Deneme {sayac}"); // Yönlendirme mesajı
            continue; // Döngünün bir sonraki turuna geçiyoruz
        }
        else // Tahmin edilen sayı büyükse
        {
            Console.WriteLine($"Biraz Daha Azalt Kalan Deneme {sayac}"); // Yönlendirme mesajı
            continue; // Döngünün bir sonraki turuna geçiyoruz
        }
    }
}
