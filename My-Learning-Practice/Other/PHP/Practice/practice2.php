<?php
class Test
{
    protected string $first = 'fred';
    protected string $last  = 'flintstone';
    public function getFirst()
    {
		//returns uppercase first
        return ucfirst($this->first);
    }
    public function getLast()
    {
        return ucfirst($this->last);
    }
    public function getName()
    {
        return $this->getFirst() . ' ' . $this->getLast();
    }
}
$test = new Test();
echo $test->getName();
echo "\n"

class UserEntity {
    public function __construct(
        public string $firstName,
        public string $lastName
    ) {}
    public function getJson()
    {
        return json_encode(get_object_vars($this), TRUE);
    }
}

$user1 = new UserEntity('Jack' , 'Ryan');
$user2 = new UserEntity('Monte' , 'Python');

echo $user1->getJson();
echo PHP_EOL;
echo $user2->getJson();
echo "\n"


class Base
{
    public int $a;
    public int $b;
    public function add(int $a, int $b)
    {
        return $a + $b;
    }
}

//
class Whatever extends Base
{
    // this works:
    public function add(int|float $a, int|float $b, int|float $c = 0)
    {
        return $a + $b + $c;
    }
   
}

$what = new Whatever();
echo $what->add(1, 2, 3);
echo "\n"
