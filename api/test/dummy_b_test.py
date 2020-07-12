import unittest


class DummyA(unittest.TestCase):

    def test_dummy_b_1(self):
        self.assertTrue(True)

    def test_dummy_b_2(self):
        self.assertTrue(True)


if __name__ == '__main__':
    unittest.main()