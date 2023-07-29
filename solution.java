Here is a Java console application that solves the problem:

```java
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Set<String> dictionary = new HashSet<>(Arrays.asList("apple", "pen", "applepen", "pine", "pineapple"));
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a string:");
        String input = scanner.nextLine();
        System.out.println("Can the string be segmented? " + canSegmentString(input, dictionary));
    }

    public static boolean canSegmentString(String input, Set<String> dictionary) {
        if (input == null || input.length() == 0) {
            return false;
        }
        int len = input.length();
        boolean[] canSegment = new boolean[len + 1];
        canSegment[0] = true;
        for (int i = 1; i <= len; i++) {
            for (int j = 0; j < i; j++) {
                if (canSegment[j] && dictionary.contains(input.substring(j, i))) {
                    canSegment[i] = true;
                    break;
                }
            }
        }
        return canSegment[len];
    }
}
```

This console application first creates a dictionary of words. Then it asks the user to input a string. It checks if the string can be segmented into words from the dictionary by using dynamic programming. The `canSegmentString` method returns `true` if the string can be segmented and `false` otherwise.