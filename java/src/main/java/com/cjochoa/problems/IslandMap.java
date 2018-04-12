package com.cjochoa.problems;


/**
 * This class receives a map at construction time, and offers a method that
 * determines the size of an island given a coordinate (point in the map).
 * A map is a rectangular matrix of integer values, where 0 represent water,
 * and anything different from 0 represents land.
 * The size of a island is the sum of all land values (different from 0) that
 * contain the passed coordinate.
 * For example, given the map
 *
 * {0,0,1,0}
 * {0,1,1,0}
 * {1,0,1,0}
 *
 * then
 *
 * size(0,2) = 4
 * size(1,1) = 4
 * size(2,0) = 1
 * size(0,0) = 0
 *
 */
public class IslandMap {

    private final int[][] map;
    private final int rows;
    private final int columns;

    public IslandMap(final int[][] map) {
        this.map = map;
        this.rows = map.length;
        this.columns = map[0].length;
    }

    public int size(final int row, final int column) {

        boolean[][] marks = new boolean[rows][columns]; // this gets initialized to false
        return sizeAux(marks, row, column);
    }


    private int sizeAux(boolean[][] marks, int row, int column) {
        if (row < 0 || column < 0 || row >= this.rows || column >= this.columns) {
            return 0;
        }
        if (map[row][column] == 0) {
            return 0;
        }
        if (marks[row][column]) {
            // this coordinate has already been processed
            return 0;
        }

        marks[row][column] = true;
        return 1 + sizeAux(marks, row - 1, column) + // left
                sizeAux(marks, row + 1, column) + // right
                sizeAux(marks, row, column - 1) + // up
                sizeAux(marks, row, column + 1); // down
    }
}
