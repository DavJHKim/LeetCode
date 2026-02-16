def two_sum(nums: List[int], target: int) -> List[int]:
    hashMap = {}

    for i in range(len(nums)):
        other = target - nums[i]
        if other in hashMap:
            return [hashMap[other], i]
        hashMap[nums[i]] = i 
    return []
