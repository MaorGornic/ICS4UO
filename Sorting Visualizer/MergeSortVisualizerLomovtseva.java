import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)
import java.util.*;

/**
 * MergeSortVisualizerLomovtseva implements a Merge sorting algorithim 
 * by first spliting objects and then merging them. 
 * @author (A. Lomovtseva) 
 * @version (1.0)
 */
public class MergeSortVisualizerLomovtseva extends Actor
{
    // Stack used to workaround recursion
    Stack splits = new Stack();
    boolean firstRun = true;
    
    public void act() 
    {
        SortingVisualization sortingWorld = this.getWorldOfType(SortingVisualization.class);
        List blockList = sortingWorld.getBlockList();
        // First run
        if (firstRun)
        {
           //Creates a list for indexes
           List indexes = new ArrayList();
           //Adds the indexes to the list
           for(int i =  0; i < blockList.size(); i++)
           {
               indexes.add(i);
           }
           // Sort recursively and save splits
           sort(indexes, splits);
           firstRun = false;
        }

        //Merge one split per act call until Stack is empty
        if (!splits.empty())
        {
            merge(blockList, splits);
            sortingWorld.displayList();
        }
    }
   
    /*
     * Sort and save all splits recursively
     * 
     * @param list of indexes
     * @param stack for splits
     */
    private void sort(List list, Stack splits)
    {
        if (list.size() < 2) return;

        //Create split
        int mid = list.size()/2;
        List left = list.subList(0, mid);
        List right =  list.subList(mid, list.size());
        
        //Push split onto stack (it is a list of 2 elements: left and right) 
        List split = new ArrayList();
        split.add(left);
        split.add(right);
        splits.push(split);
        //Continue sorting recursively
        sort(left, splits);
        sort(right, splits);
    }

  
    /*
     * Merge one split
     *
     * @param the block list
     * @param stack of splits
     */
    private void merge(List blocks, Stack splits) 
    {
        // Get split from stack
        List split = (List)splits.pop();
        
        List left = (List)split.get(0);
        List right = (List)split.get(1);
        
        //Make a copy of original array so indexes refer to original positions later.
        //We have to do this since we make changes in block list 
        List original = new ArrayList();
        original.addAll(blocks);
        
        int leftIndex = 0;
        int rightIndex = 0;
        int listIndex = (int)left.get(leftIndex);
    
        //First merge left and right lists as much as possible
        while (leftIndex < left.size() && rightIndex < right.size()) 
        {
          //Get left index
          int originalLeftIndex = (int)left.get(leftIndex);
          //Get corresponding block
          Block leftBlock = (Block)original.get(originalLeftIndex);
          //Get right index
          int originalRightIndex = (int)right.get(rightIndex);
          //Get corresponding block
          Block rightBlock = (Block)original.get(originalRightIndex);
    
          //Compare and set in block list
          if (leftBlock.getValue() < rightBlock.getValue())  {
            blocks.set(listIndex++, leftBlock);
            leftIndex++;
          } else {
            blocks.set(listIndex++, rightBlock);
            rightIndex++;
          }
        }
        
        //Process reminder of elements from left list 
        while (leftIndex < left.size()) 
        {
          int originalLeftIndex = (int)left.get(leftIndex);
          Block leftBlock = (Block)original.get(originalLeftIndex);
          blocks.set(listIndex++, leftBlock);
          leftIndex++;
        }
    
        //Process reminder of elements from right list
        while (rightIndex < right.size()) 
        {
          int originalRightIndex = (int)right.get(rightIndex);
          Block rightBlock = (Block)original.get(originalRightIndex);
          blocks.set(listIndex++, rightBlock);
          rightIndex++;
        }
    }
}