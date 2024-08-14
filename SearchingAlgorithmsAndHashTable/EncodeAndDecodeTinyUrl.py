from ast import Nonlocal


class Codec:
    def __init__(self) -> None:
        self.hashMap = {}
        self.counter = 0

    def encode(self, longUrl: str) -> str:
        shortUrl = "http://tinyurl.com/{counter}"
        self.hashMap[shortUrl] = longUrl
        self.counter += 1
        return shortUrl

    def decode(self, shortUrl: str) -> str:
        return self.hashMap[shortUrl]


# Your Codec object will be instantiated and called as such:
# codec = Codec()
# codec.decode(codec.encode(url))
