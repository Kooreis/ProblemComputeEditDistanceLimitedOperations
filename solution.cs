function minDistance(word1, word2) {
    var len1 = word1.length;
    var len2 = word2.length;

    var dp = new Array(len1 + 1);
    for (var i = 0; i < len1 + 1; i++) {
        dp[i] = new Array(len2 + 1);
    }
}