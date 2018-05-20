require 'fizzbuzz'

class TestFizzBuzz < Test::Unit::TestCase
    def test_3
        assert_equal('fizz', FizzBuzz.result(3))
    end

    def test_5
        assert_equal('buzz', FizzBuzz.result(5))
    end

    def test_13
        assert_equal('fizz', FizzBuzz.result(13))
    end

    def test_15
        assert_equal('fizzbuzz', FizzBuzz.result(15))
    end

    def test_30
        assert_equal('fizzbuzz', FizzBuzz.result(30))
    end
end