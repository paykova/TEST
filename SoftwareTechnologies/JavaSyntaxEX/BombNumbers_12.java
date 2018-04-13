import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class BombNumbers_12 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        List<Integer> nums = Arrays
                .stream(scan.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());

        int[] infoNums = Arrays
                .stream(scan.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int specialNum = infoNums[0];
        int power = infoNums[1];


        while (nums.contains(specialNum)) {
            int leftIndex = (nums.indexOf(specialNum) - power) < 0
                    ? 0
                    : (nums.indexOf(specialNum) - power);

/*            if (leftIndex < 0) {
                leftIndex = 0;
            }*/

            int rightIndex = (nums.indexOf(specialNum) + power) >= nums.size()
                    ? nums.size() - 1
                    : (nums.indexOf(specialNum) + power);

           /* if (rightIndex >= nums.size()) {
                rightIndex = nums.size()-1;
            }*/

            nums.subList(leftIndex, rightIndex + 1).clear();
        }

        int sum = nums.stream().mapToInt(Integer::intValue).sum();

        System.out.println(sum);
    }
}
