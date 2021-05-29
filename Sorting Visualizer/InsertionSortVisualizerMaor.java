import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)
import java.util.*;

/**
 * A visual implementation of the Insertion sort algorithm in Java that at every iteration in the loop compares the
 * number in the previous index with the one in the current and swaps them if the number in the previous index is greater
 * than the one in the current index.
 * 
 * Diagram (Visual Outliner): https://he-s3.s3.amazonaws.com/media/uploads/46bfac9.png
 * 
 * @author M. Gornik
 * @version v1.0
 */
public class InsertionSortVisualizerMaor extends Actor
{
    private List<Block> blockList; // A list containing all the block objects in the world
    private SortingVisualization sortingWorld; // A reference to the world object
    private static final long DELAY = 70; // The delay between every individual block sorting step that takes place
    private long delayCount; // A counter that waits until the maximum delay time is reached

    /**
     * Act - do whatever the MergeSortVisualizerMaor wants to do. This method is called whenever
     * the 'Act' or 'Run' button gets pressed in the environment.
     */
    public void act() {
        sortingWorld = (SortingVisualization)getWorld(); // Storing the world's object reference
        blockList = sortingWorld.getBlockList(); // Storing the list of blocks added from the world class

        // Compraing two blocks based on their numbers and swapping them if required
        for (int i = 1; i < blockList.size(); i++) {
            for (int j = i; j > 0 && blockList.get(j - 1).getValue() > blockList.get(j).getValue(); j--) {

                // Delaying the swapping so the animation will be visible
                if(delayCount < DELAY) {
                    delayCount++;

                } else {
                    // Resetting the delay each time swapping takes place
                    delayCount = 0; 
                    // Swapping the two numbers
                    Collections.swap(blockList, j, j - 1);
                }
                // Updating so the blocks will move to their new position in the list
                sortingWorld.displayList();
            }
        }
    }
}

