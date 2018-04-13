import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfEqualElements_07 {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int[] nums = Arrays.stream(reader.readLine()
                .split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int currentLength = 1;
        int currentStart = 0;
        int longestStart = 0;
        int longestLength = 1;


        for (int i = 1; i < nums.length; i++) {
            if (nums[i] == nums[i - 1]) {
                currentLength++;

                if (currentLength > longestLength) {
                    longestLength = currentLength;
                    longestStart = currentStart;
                }
            } else {
                currentLength = 1;
                currentStart = i;
            }
        }
        for (int i = longestStart; i < longestStart + longestLength; i++) {
            System.out.print(nums[i] + " ");
        }
    }
}
