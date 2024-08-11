Here is a TypeScript solution for the problem:

```typescript
function minDistance(word1: string, word2: string): number {
    const m = word1.length, n = word2.length;
    let dp: number[][] = Array(m + 1).fill(0).map(() => Array(n + 1).fill(0));
    for (let i = 0; i <= m; i++) {
        dp[i][0] = i;
    }
    for (let j = 0; j <= n; j++) {
        dp[0][j] = j;
    }
    for (let i = 1; i <= m; i++) {
        for (let j = 1; j <= n; j++) {
            if (word1.charAt(i - 1) == word2.charAt(j - 1)) {
                dp[i][j] = dp[i - 1][j - 1];
            } else {
                dp[i][j] = Math.min(dp[i - 1][j - 1], dp[i - 1][j], dp[i][j - 1]) + 1;
            }
        }
    }
    return dp[m][n];
}

console.log(minDistance('kitten', 'sitting'));
```

This program calculates the minimum number of operations required to convert one string to another. The operations allowed are insert a character, delete a character, and replace a character. The program uses dynamic programming to solve the problem. The `minDistance` function creates a 2D array `dp` where `dp[i][j]` is the minimum number of operations that converts `word1[0..i-1]` to `word2[0..j-1]`. The function then fills the `dp` array in a bottom-up manner and finally returns `dp[m][n]`.