import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class EqualSums_11 {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int[] nums = Arrays.stream(reader.readLine()
                .split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        boolean isEqual = false;

        for (int i = 0; i < nums.length; i++) {
            int leftPart = Arrays.stream(nums, 0, i).sum();
            int rightPart = Arrays.stream(nums, i + 1, nums.length).sum();

            if (leftPart == rightPart) {
                System.out.println(i);
                isEqual = true;
                break; // break will exit the for-loop
            }
        }
        if (!isEqual){
            System.out.println("no");
        }
    }
}
