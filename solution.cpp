```cpp
#include <iostream>
#include <string>
#include <vector>

int min(int x, int y, int z) {
    return std::min(std::min(x, y), z);
}

int editDist(std::string str1, std::string str2, int m, int n) {
    std::vector<std::vector<int>> dp(m + 1, std::vector<int>(n + 1));

    for (int i = 0; i <= m; i++) {
        for (int j = 0; j <= n; j++) {
            if (i == 0)
                dp[i][j] = j;

            else if (j == 0)
                dp[i][j] = i;

            else if (str1[i - 1] == str2[j - 1])
                dp[i][j] = dp[i - 1][j - 1];

            else
                dp[i][j] = 1 + min(dp[i][j - 1], dp[i - 1][j], dp[i - 1][j - 1]);
        }
    }

    return dp[m][n];
}

int main() {
    std::string str1;
    std::string str2;

    std::cout << "Enter first word: ";
    std::cin >> str1;

    std::cout << "Enter second word: ";
    std::cin >> str2;

    std::cout << "Edit Distance: " << editDist(str1, str2, str1.length(), str2.length()) << std::endl;

    return 0;
}
```