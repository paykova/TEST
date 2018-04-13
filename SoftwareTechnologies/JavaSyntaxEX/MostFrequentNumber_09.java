import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class MostFrequentNumber_09 {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int[] input = Arrays.stream(reader.readLine()
                .split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int mostFrequentNum = 0;
        int maxCounter = 0;

        for (int i = 0; i < input.length; i++) {
            int currentNumber = input[i];
            int counter = 0;

            for (int j = 0; j < input.length; j++) {
                if (currentNumber == input[j]) {
                    counter++;
                }
            }

            if (counter > maxCounter) {
                mostFrequentNum = currentNumber;
                maxCounter = counter;
            }
        }
        System.out.println(mostFrequentNum);
    }
}


