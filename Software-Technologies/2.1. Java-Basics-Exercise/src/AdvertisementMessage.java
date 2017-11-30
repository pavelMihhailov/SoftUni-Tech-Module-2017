import java.util.Random;
import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

public class AdvertisementMessage {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] phrases = {"Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can't live without this product."};
        String[] events = {"Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"};
        String[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
        String[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

        Random rnd = new Random();

        int phrasesIndex = ThreadLocalRandom.current().nextInt(0, phrases.length);
        int eventsIndex = ThreadLocalRandom.current().nextInt(0, events.length);
        int authorsIndex = ThreadLocalRandom.current().nextInt(0, authors.length);
        int citiesIndex = ThreadLocalRandom.current().nextInt(0, cities.length);

        System.out.printf("%s %s %s - %s", phrases[phrasesIndex], events[eventsIndex],
                authors[authorsIndex], cities[citiesIndex]);
    }
}
