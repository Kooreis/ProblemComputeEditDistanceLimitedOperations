for (var i = 0; i <= len1; i++) {
        dp[i][0] = i;
    }

    for (var j = 0; j <= len2; j++) {
        dp[0][j] = j;
    }