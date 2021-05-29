import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)
import java.util.*;

/**
 * My Implementation of the quicksort algorithm to visualize how it works
 * 
 * @author E. Callanan 
 * @version v1.0
 */
public class QuickSortVisualizerCallanan extends Actor
{
    
    Boolean started; //Checks if the algorithm has started yet
    
    /**
     * Constructor for QuickSortVisualizerCallanan
     * Just scales the icon
     */
    public QuickSortVisualizerCallanan(){
        //getImage().scale(50, 50); //scale the image down 
        started = false;
        
    }
   
    /**
     * The main, recursive function that runs the sorting
     * 
     * Repeatedly splits and sorts sections of the list untill it is all sorted
     * 
     * @param list of blocks from the world
     * @param starting index of the list
     * @param highest index in the list
     */
    public void quickSort(List blockList, int start, int end){
        //Only run if the starting index for this iteration is less than the end
        if (start < end){
            //set the partition index to the return value of the partiton function
            int pIndex = partition(blockList, start, end); 
            
            //Split and sort the list around the partition
            
            
            //Call this function using the same list, same start index, and the index before the partition as the end
            quickSort(blockList, start, pIndex - 1);
            
            
            //Call this function using the same list, the index after the partition as start and the same end
            quickSort(blockList, pIndex + 1, end);
        }
        
         
    }
    
    /**
     * The partioning function
     * 
     * Takes a section of the list, uses the last block in that section as the "pivot"
     * Moves the blocks around until the pivot is in the right place
     * Returns where the pivot ends up so the quicksort function can then partion a smaller
     * section based on this.
     * The process repeats (moving one block to the right spot, breaking the list apart, etc)
     * until all the blocks are in the right spot
     * 
     * Note:
     *          2 instances of this function will always be running as the quicksort 
     *          function calls itself twice. This means there will be 2 pivots moving at once
     *          
     * 
     * @param the block list
     * @param the index to start sorting from
     * @param the index to stop sorting at
     * 
     * @return the index where the pivot ends up
     */
    public int partition(List blockList, int start, int end){
       Block pivot = (Block)blockList.get(end); //pivot at the given ending index
       
       //The index of the largest block that is smaller than the pivot
       int smallerIndex = start - 1; //Start it off as the first block in this section of the list
       
       //Start at the starting index and make necessary swaps until it has gone through to the ending index 
       for (int i = start; i <= end - 1; i++){
            
            Block current = (Block)blockList.get(i);
            
            //If the current block is smaller than the pivot block
            if ( current.getValue() <= pivot.getValue() ){
                smallerIndex++;    // increment index of largest smaller block
                
                // swap smaller block with current block
                Block smallBlock = (Block)blockList.get(smallerIndex); 
                blockList.set(smallerIndex, current); 
                blockList.set(i, smallBlock); 
                
                update();
            }
       }
        
        // Move the pivot to right after the block we know is the largest one smaller than the pivot
        //This means the pivot is in the right spot. 
        //Every block smaller is now before it in the list and every block larger is after it
        Block temp = (Block)blockList.get(smallerIndex + 1); 
        blockList.set(smallerIndex + 1, pivot); 
        blockList.set(end, temp);
        
        update();
        
       //Return the index where the pivot ended up
       return (smallerIndex + 1);
    }
    
    
    /**
     * Updates the world with the current blocklist
     */
    public void update(){
        SortingVisualization world = this.getWorldOfType(SortingVisualization.class); //Get world info
        world.displayList(); //Update the viewable blocks
        
        
        //Delay to slow down the sorting. 
        //Delays after each partition is sorted so each step can be seen
        Greenfoot.delay(1);
    }
        
    
    /**
     * Act - do whatever the QuickSortVisualizerCallanan wants to do. This method is called whenever
     * the 'Act' or 'Run' button gets pressed in the environment.
     */
    public void act() 
    {
        if (!started){
            //Start the sort
            SortingVisualization world = this.getWorldOfType(SortingVisualization.class);
            List blockList = world.getBlockList();
            
            int n = blockList.size();
            
            //Initially feed the algorithm the entire list, staring at the beginning, ending at the end
            quickSort(blockList, 0, n-1);
            
            started = true;
        }
        
        
        //This is a recursive algorithm so it all runs in a single act...
        //I used delays to slow the sorting down instead
    }    
}