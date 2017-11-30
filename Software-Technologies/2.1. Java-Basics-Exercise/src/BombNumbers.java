import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class BombNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        List<Integer> sequence = Stream.of(scanner.nextLine().split(" ")).map(Integer::parseInt).collect(Collectors.toList());
        int[] bombInfo = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int bomb = bombInfo[0];
        int power = bombInfo[1];
        for (int i = 0; i < sequence.size(); i++) {
            if (sequence.get(i) == bomb) {
                int start = i - power;
                int end = i + power;
                if(start < 0) start = 0;
                if(end > sequence.size()-1) end = sequence.size()-1;
                sequence.subList(start, end+1).clear();
                i = -1;
            }
        }
        int sum = sequence.stream().mapToInt(Integer::intValue).sum();
        System.out.println(sum);
    }
}