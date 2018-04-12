package com.cjochoa.problems;

import org.junit.Assert;
import org.junit.Test;


public class IslandMapTest {
    @Test
    public void sizeTest() {
        int[][] map =  {
            {0,0,1,0},
            {0,1,1,0},
            {1,0,1,0}};

        final IslandMap imap = new IslandMap(map);
        Assert.assertEquals(4, imap.size(0, 2));
        Assert.assertEquals(4, imap.size(1, 1));
        Assert.assertEquals(1, imap.size(2, 0));
        Assert.assertEquals(0, imap.size(0, 0));
    }

}