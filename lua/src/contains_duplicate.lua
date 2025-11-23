local M = {}

function ContainsDuplicate(nums)
    local seen = {}
    for _, num in ipairs(nums) do   
        if seen[num] then
            return true
        end 
        seen[num] = true
    end
    return false
end

local nums1 = {1, 2, 3, 4}
local nums2 = {1, 2, 3, 1}

print(ContainsDuplicate(nums1))  -- false
print(ContainsDuplicate(nums2))  -- true

return M
