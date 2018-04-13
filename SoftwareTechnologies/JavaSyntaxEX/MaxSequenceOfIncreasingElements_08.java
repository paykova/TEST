import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class MaxSequenceOfIncreasingElements_08 {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int[] input = Arrays.stream(reader.readLine()
                .split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int bestIndex = 0;
        int bestCount = 0;
        int count = 1;

        for (int j = 1; j < input.length; j++) {
            if (input[j] >= input[j - 1] + 1) {
                count++;
            } else {
                count = 1;
            }
            if (count > bestCount) {
                bestCount = count;
                bestIndex = j - count + 1;
            }
        }
        for (int i = bestIndex; i < bestIndex + bestCount; i++) {
            System.out.print(input[i] + " ");
        }
    }
}
