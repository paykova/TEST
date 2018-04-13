import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class EqualSums_11_2nd {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int[] nums = Arrays.stream(reader.readLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        for (int i = 0; i < nums.length; i++) {
            int leftSum = Arrays.stream(nums)
                    .limit(i)
                    .sum();

            int rightSum = Arrays.stream(nums)
                    .skip(i + 1)
                    .sum();

            if (leftSum == rightSum) {
                System.out.println(i);
                return; // return will exit the entire method you are currently executing - main method
            }
        }
        // If leftSum is not equal to RightSum, then will enter here:
        System.out.println("no");
    }
}
