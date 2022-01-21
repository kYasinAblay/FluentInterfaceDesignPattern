#  “Rule of 30” in Refactoring in Large Software Projects by Martin Lippert and Stephen Roock:
If an element consists of more than 30 subelements, it is highly probable that there is a serious problem:
a) Methods should not have more than an average of 30 code lines (not counting line spaces and comments).
b) A class should contain an average of less than 30 methods, resulting in up to 900 lines of code.
c) A package shouldn’t contain more than 30 classes, thus comprising up to 27,000 code lines.
d) Subsystems with more than 30 packages should be avoided. Such a subsystem would count up to 900 classes with up to 810,000 lines of code.
e) A system with 30 subsystems would thus possess 27,000 classes and 24.3 million code lines
