local contains_duplicate = require("src.contains_duplicate").ContainsDuplicate
local unit = require("luaunit")

TestsContainsDuplicate = {}

function TestContainsDuplicate:test_no_duplicates()
    luaunit.assertFalse(containsDuplicate({1, 2, 3, 4}))
end

function TestContainsDuplicate:test_with_duplicates()
    luaunit.assertTrue(containsDuplicate({1, 2, 3, 1}))
end

function TestContainsDuplicate:test_all_same()
    luaunit.assertTrue(containsDuplicate({5, 5, 5, 5, 5}))
end

function TestContainsDuplicate:test_single_element()
    luaunit.assertFalse(containsDuplicate({9}))
end

function TestContainsDuplicate:test_empty_array()
    luaunit.assertFalse(containsDuplicate({}))
end

function TestContainsDuplicate:test_negative_numbers()
    luaunit.assertTrue(containsDuplicate({-3, -2, -3}))
end

os.exit(luaunit.LuaUnit.run())
