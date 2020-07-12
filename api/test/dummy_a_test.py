import unittest


class DummyB(unittest.TestCase):

    def test_dummy_a_1(self):
        self.assertTrue(True)

    def test_dummy_a_2(self):
        self.assertTrue(True)


if __name__ == '__main__':
    unittest.main()