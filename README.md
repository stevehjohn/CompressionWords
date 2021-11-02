# Huffman Words

An experiment to see whether using a Huffman tree for words results in better compression ratios.

Spun off from my original [Huffman implementation](https://github.com/stevehjohn/Huffman).

Not too worried about benchmarks for this one, just interested in whether using words is more efficient than just characters.

## Results

Downloaded some public domain novels from Project Gutenberg. Here's how they compress.

- A Tale of Two Cities

```
Original size: 792,968 bytes.
Compressed size:  bytes.
Ratio: %
```

[Huffman Tree Visualisation](https://htmlpreview.github.io/?https://github.com/stevehjohn/HuffmanWords/blob/master/visualisations/A%20Tale%20of%20Two%20Cities.html)

- Frankenstein or the Modern Prometheus

```
Original size: 448,844 bytes.
Compressed size:  bytes.
Ratio: %
```

[Huffman Tree Visualisation](https://htmlpreview.github.io/?https://github.com/stevehjohn/HuffmanWords/blob/master/visualisations/Frankenstein%20or%20the%20Modern%20Prometheus.html)

- Great Expectations

```
Original size: 1,035,187 bytes.
Compressed size:  bytes.
Ratio: %
```

[Huffman Tree Visualisation](https://htmlpreview.github.io/?https://github.com/stevehjohn/HuffmanWords/blob/master/visualisations/Great%20Expectations.html)

- Les Misérables

```
Original size: 3,325,127 bytes.
Compressed size:  bytes.
Ratio: %
```

[Huffman Tree Visualisation](https://htmlpreview.github.io/?https://github.com/stevehjohn/HuffmanWords/blob/master/visualisations/Les%20Mis%C3%A9rables.html)

- Pride and Prejudice

```
Original size: 790,334 bytes.
Compressed size: bytes.
Ratio: %
```

[Huffman Tree Visualisation](https://htmlpreview.github.io/?https://github.com/stevehjohn/HuffmanWords/blob/master/visualisations/Pride%20and%20Prejudice.html)

- War of the Worlds

```
Original size: 363,744 bytes.
Compressed size:  bytes.
Ratio: %
```

[Huffman Tree Visualisation](https://htmlpreview.github.io/?https://github.com/stevehjohn/HuffmanWords/blob/master/visualisations/War%20of%20the%20Worlds.html)
