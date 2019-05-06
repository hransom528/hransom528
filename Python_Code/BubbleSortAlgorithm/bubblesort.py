
isFinished = False
nums = [5,3,1,2,4]



def bubbleSort(arr):
    length = len(arr)
 
    # Traverse through all array elements
    for i in range(length):
 
        # Last i elements are already in place
        for j in range(0, length-i-1):
 
            # traverse the array from 0 to n-i-1
            # Swap if the element found is greater
            # than the next element
            if arr[j] > arr[j+1] :
                arr[j], arr[j+1] = arr[j+1], arr[j]

bubbleSort(nums)

for i in (len(nums) - 1):
    print(nums[i])

