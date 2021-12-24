# Zero-Width-Steganography
A simple gui program that uses steganographic encryption to hide secret messages inside of text.
This method will hide text in plain sight using invisible zero-width characters, although some text editors may make it obvious that invisible characters are present in the string.
This tool was inspired by [Steganographr](https://github.com/neatnik/steganographr).

## Characters
This tool uses:
- WORD JOINER (U+2060)
- ZERO WIDTH SPACE (U+200B)
- ZERO WIDTH NON-JOINER (U+200C)

##
Screenshots:

*Encryption Window*
<img width="601" alt="Hide" src="https://user-images.githubusercontent.com/31434698/147337917-fb889b4a-3373-4f1f-92d1-672645e4cbe1.PNG">

*Decryption Window*
<img width="601" alt="Reveal" src="https://user-images.githubusercontent.com/31434698/147337891-094a30e7-abd6-46f6-ad38-c398ff550dac.PNG">
