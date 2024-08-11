Here is a JavaScript solution for the problem:

```javascript
function minDistance(word1, word2) {
    var len1 = word1.length;
    var len2 = word2.length;

    var dp = new Array(len1 + 1);
    for (var i = 0; i < len1 + 1; i++) {
        dp[i] = new Array(len2 + 1);
    }

    for (var i = 0; i <= len1; i++) {
        dp[i][0] = i;
    }

    for (var j = 0; j <= len2; j++) {
        dp[0][j] = j;
    }

    for (var i = 1; i <= len1; i++) {
        for (var j = 1; j <= len2; j++) {
            if (word1.charAt(i - 1) == word2.charAt(j - 1)) {
                dp[i][j] = dp[i - 1][j - 1];
            } else {
                dp[i][j] = Math.min(dp[i - 1][j - 1], dp[i - 1][j], dp[i][j - 1]) + 1;
            }
        }
    }

    return dp[len1][len2];
}

console.log(minDistance('kitten', 'sitting'));
```

This console application computes the edit distance between two words. The edit distance is the minimum number of operations (insertions, deletions, and substitutions) required to transform one word into another. The application uses dynamic programming to solve the problem. It creates a 2D array where dp[i][j] represents the minimum number of operations required to convert word1[0..i-1] to word2[0..j-1]. The final result is stored in dp[len1][len2].