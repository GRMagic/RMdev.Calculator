namespace RMdev.Calculator.Compiler
{
    static class ParserConstants
    {
        public const int FIRST_SEMANTIC_ACTION = 26;

        public const int SHIFT = 0;
        public const int REDUCE = 1;
        public const int ACTION = 2;
        public const int ACCEPT = 3;
        public const int GO_TO = 4;
        public const int ERROR = 5;

        public static readonly int[][][] PARSER_TABLE =
        {
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { GO_TO ,  1}, new[] { GO_TO ,  2}, new[] { GO_TO ,  3}, new[] { GO_TO ,  4},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACCEPT,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 17}, new[] { SHIFT , 18}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE,  2}, new[] { ERROR ,  0}, new[] { REDUCE,  2}, new[] { REDUCE,  2}, new[] { SHIFT , 20},
                new[] { SHIFT , 19}, new[] { SHIFT , 21}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { REDUCE,  2},
                new[] { REDUCE,  2}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE,  6}, new[] { ERROR ,  0}, new[] { REDUCE,  6}, new[] { REDUCE,  6}, new[] { REDUCE,  6},
                new[] { REDUCE,  6}, new[] { REDUCE,  6}, new[] { SHIFT , 22}, new[] { ERROR ,  0}, new[] { REDUCE,  6},
                new[] { REDUCE,  6}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE,  8}, new[] { ERROR ,  0}, new[] { REDUCE,  8}, new[] { REDUCE,  8}, new[] { REDUCE,  8},
                new[] { REDUCE,  8}, new[] { REDUCE,  8}, new[] { REDUCE,  8}, new[] { ERROR ,  0}, new[] { REDUCE,  8},
                new[] { REDUCE,  8}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { GO_TO , 23}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE, 10}, new[] { ERROR ,  0}, new[] { REDUCE, 10}, new[] { REDUCE, 10}, new[] { REDUCE, 10},
                new[] { REDUCE, 10}, new[] { REDUCE, 10}, new[] { REDUCE, 10}, new[] { ERROR ,  0}, new[] { REDUCE, 10},
                new[] { REDUCE, 10}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE, 11}, new[] { ERROR ,  0}, new[] { REDUCE, 11}, new[] { REDUCE, 11}, new[] { REDUCE, 11},
                new[] { REDUCE, 11}, new[] { REDUCE, 11}, new[] { REDUCE, 11}, new[] { ERROR ,  0}, new[] { REDUCE, 11},
                new[] { REDUCE, 11}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { GO_TO , 24}, new[] { GO_TO ,  2}, new[] { GO_TO ,  3}, new[] { GO_TO ,  4},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE, 13}, new[] { ERROR ,  0}, new[] { REDUCE, 13}, new[] { REDUCE, 13}, new[] { REDUCE, 13},
                new[] { REDUCE, 13}, new[] { REDUCE, 13}, new[] { REDUCE, 13}, new[] { ERROR ,  0}, new[] { REDUCE, 13},
                new[] { REDUCE, 13}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION,  1}, new[] { ERROR ,  0}, new[] { ACTION,  1}, new[] { ACTION,  1}, new[] { ACTION,  1},
                new[] { ACTION,  1}, new[] { ACTION,  1}, new[] { ACTION,  1}, new[] { ERROR ,  0}, new[] { ACTION,  1},
                new[] { ACTION,  1}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { GO_TO , 25}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE, 15}, new[] { ERROR ,  0}, new[] { REDUCE, 15}, new[] { REDUCE, 15}, new[] { REDUCE, 15},
                new[] { REDUCE, 15}, new[] { REDUCE, 15}, new[] { REDUCE, 15}, new[] { ERROR ,  0}, new[] { REDUCE, 15},
                new[] { REDUCE, 15}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 26}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 27}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 28}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 29}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION,  0}, new[] { ERROR ,  0}, new[] { ACTION,  0}, new[] { ACTION,  0}, new[] { ACTION,  0},
                new[] { ACTION,  0}, new[] { ACTION,  0}, new[] { ACTION,  0}, new[] { ERROR ,  0}, new[] { ACTION,  0},
                new[] { ACTION,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { GO_TO , 30}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { ERROR ,  0}, new[] { GO_TO , 31}, new[] { GO_TO ,  3}, new[] { GO_TO ,  4},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { ERROR ,  0}, new[] { GO_TO , 32}, new[] { GO_TO ,  3}, new[] { GO_TO ,  4},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 33}, new[] { GO_TO ,  4},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 34}, new[] { GO_TO ,  4},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 35}, new[] { GO_TO ,  4},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 36},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION, 16}, new[] { ERROR ,  0}, new[] { ACTION, 16}, new[] { ACTION, 16}, new[] { ACTION, 16},
                new[] { ACTION, 16}, new[] { ACTION, 16}, new[] { ACTION, 16}, new[] { ERROR ,  0}, new[] { ACTION, 16},
                new[] { ACTION, 16}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { GO_TO , 37}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 17}, new[] { SHIFT , 18}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 38},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE, 14}, new[] { ERROR ,  0}, new[] { REDUCE, 14}, new[] { REDUCE, 14}, new[] { REDUCE, 14},
                new[] { REDUCE, 14}, new[] { REDUCE, 14}, new[] { REDUCE, 14}, new[] { ERROR ,  0}, new[] { REDUCE, 14},
                new[] { REDUCE, 14}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { GO_TO , 39}, new[] { GO_TO ,  2}, new[] { GO_TO ,  3}, new[] { GO_TO ,  4},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { GO_TO , 40}, new[] { GO_TO ,  2}, new[] { GO_TO ,  3}, new[] { GO_TO ,  4},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3},
                new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3},
                new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3},
                new[] { ACTION,  3}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 41}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3},
                new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3},
                new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3}, new[] { ACTION,  3},
                new[] { ACTION,  3}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 42}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE, 16}, new[] { ERROR ,  0}, new[] { REDUCE, 16}, new[] { REDUCE, 16}, new[] { REDUCE, 16},
                new[] { REDUCE, 16}, new[] { REDUCE, 16}, new[] { REDUCE, 16}, new[] { ERROR ,  0}, new[] { REDUCE, 16},
                new[] { REDUCE, 16}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION, 10}, new[] { ERROR ,  0}, new[] { ACTION, 10}, new[] { ACTION, 10}, new[] { SHIFT , 20},
                new[] { SHIFT , 19}, new[] { SHIFT , 21}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ACTION, 10},
                new[] { ACTION, 10}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { GO_TO , 43}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION, 11}, new[] { ERROR ,  0}, new[] { ACTION, 11}, new[] { ACTION, 11}, new[] { SHIFT , 20},
                new[] { SHIFT , 19}, new[] { SHIFT , 21}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ACTION, 11},
                new[] { ACTION, 11}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { GO_TO , 44}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION, 12}, new[] { ERROR ,  0}, new[] { ACTION, 12}, new[] { ACTION, 12}, new[] { ACTION, 12},
                new[] { ACTION, 12}, new[] { ACTION, 12}, new[] { SHIFT , 22}, new[] { ERROR ,  0}, new[] { ACTION, 12},
                new[] { ACTION, 12}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 45}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION, 13}, new[] { ERROR ,  0}, new[] { ACTION, 13}, new[] { ACTION, 13}, new[] { ACTION, 13},
                new[] { ACTION, 13}, new[] { ACTION, 13}, new[] { SHIFT , 22}, new[] { ERROR ,  0}, new[] { ACTION, 13},
                new[] { ACTION, 13}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 46}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION, 14}, new[] { ERROR ,  0}, new[] { ACTION, 14}, new[] { ACTION, 14}, new[] { ACTION, 14},
                new[] { ACTION, 14}, new[] { ACTION, 14}, new[] { SHIFT , 22}, new[] { ERROR ,  0}, new[] { ACTION, 14},
                new[] { ACTION, 14}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 47},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION, 15}, new[] { ERROR ,  0}, new[] { ACTION, 15}, new[] { ACTION, 15}, new[] { ACTION, 15},
                new[] { ACTION, 15}, new[] { ACTION, 15}, new[] { ACTION, 15}, new[] { ERROR ,  0}, new[] { ACTION, 15},
                new[] { ACTION, 15}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { GO_TO , 48}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE,  9}, new[] { ERROR ,  0}, new[] { REDUCE,  9}, new[] { REDUCE,  9}, new[] { REDUCE,  9},
                new[] { REDUCE,  9}, new[] { REDUCE,  9}, new[] { REDUCE,  9}, new[] { ERROR ,  0}, new[] { REDUCE,  9},
                new[] { REDUCE,  9}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE, 12}, new[] { ERROR ,  0}, new[] { REDUCE, 12}, new[] { REDUCE, 12}, new[] { REDUCE, 12},
                new[] { REDUCE, 12}, new[] { REDUCE, 12}, new[] { REDUCE, 12}, new[] { ERROR ,  0}, new[] { REDUCE, 12},
                new[] { REDUCE, 12}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 17}, new[] { SHIFT , 18}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 50},
                new[] { SHIFT , 49}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 17}, new[] { SHIFT , 18}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 51},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { GO_TO , 53}, new[] { GO_TO ,  2}, new[] { GO_TO ,  3}, new[] { GO_TO ,  4},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { GO_TO , 52},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { GO_TO , 53}, new[] { GO_TO ,  2}, new[] { GO_TO ,  3}, new[] { GO_TO ,  4},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { GO_TO , 54},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE,  0}, new[] { ERROR ,  0}, new[] { REDUCE,  0}, new[] { REDUCE,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { REDUCE,  0},
                new[] { REDUCE,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE,  1}, new[] { ERROR ,  0}, new[] { REDUCE,  1}, new[] { REDUCE,  1}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { REDUCE,  1},
                new[] { REDUCE,  1}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE,  3}, new[] { ERROR ,  0}, new[] { REDUCE,  3}, new[] { REDUCE,  3}, new[] { REDUCE,  3},
                new[] { REDUCE,  3}, new[] { REDUCE,  3}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { REDUCE,  3},
                new[] { REDUCE,  3}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE,  4}, new[] { ERROR ,  0}, new[] { REDUCE,  4}, new[] { REDUCE,  4}, new[] { REDUCE,  4},
                new[] { REDUCE,  4}, new[] { REDUCE,  4}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { REDUCE,  4},
                new[] { REDUCE,  4}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE,  5}, new[] { ERROR ,  0}, new[] { REDUCE,  5}, new[] { REDUCE,  5}, new[] { REDUCE,  5},
                new[] { REDUCE,  5}, new[] { REDUCE,  5}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { REDUCE,  5},
                new[] { REDUCE,  5}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE,  7}, new[] { ERROR ,  0}, new[] { REDUCE,  7}, new[] { REDUCE,  7}, new[] { REDUCE,  7},
                new[] { REDUCE,  7}, new[] { REDUCE,  7}, new[] { REDUCE,  7}, new[] { ERROR ,  0}, new[] { REDUCE,  7},
                new[] { REDUCE,  7}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { GO_TO , 55}, new[] { GO_TO ,  2}, new[] { GO_TO ,  3}, new[] { GO_TO ,  4},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION, 18}, new[] { ERROR ,  0}, new[] { ACTION, 18}, new[] { ACTION, 18}, new[] { ACTION, 18},
                new[] { ACTION, 18}, new[] { ACTION, 18}, new[] { ACTION, 18}, new[] { ERROR ,  0}, new[] { ACTION, 18},
                new[] { ACTION, 18}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 56}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION, 19}, new[] { ERROR ,  0}, new[] { ACTION, 19}, new[] { ACTION, 19}, new[] { ACTION, 19},
                new[] { ACTION, 19}, new[] { ACTION, 19}, new[] { ACTION, 19}, new[] { ERROR ,  0}, new[] { ACTION, 19},
                new[] { ACTION, 19}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 57},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 58},
                new[] { SHIFT , 59}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 17}, new[] { SHIFT , 18}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ACTION,  4},
                new[] { ACTION,  4}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 60},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 61},
                new[] { SHIFT , 59}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 17}, new[] { SHIFT , 18}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 62},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE, 18}, new[] { ERROR ,  0}, new[] { REDUCE, 18}, new[] { REDUCE, 18}, new[] { REDUCE, 18},
                new[] { REDUCE, 18}, new[] { REDUCE, 18}, new[] { REDUCE, 18}, new[] { ERROR ,  0}, new[] { REDUCE, 18},
                new[] { REDUCE, 18}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE, 19}, new[] { ERROR ,  0}, new[] { REDUCE, 19}, new[] { REDUCE, 19}, new[] { REDUCE, 19},
                new[] { REDUCE, 19}, new[] { REDUCE, 19}, new[] { REDUCE, 19}, new[] { ERROR ,  0}, new[] { REDUCE, 19},
                new[] { REDUCE, 19}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION, 20}, new[] { ERROR ,  0}, new[] { ACTION, 20}, new[] { ACTION, 20}, new[] { ACTION, 20},
                new[] { ACTION, 20}, new[] { ACTION, 20}, new[] { ACTION, 20}, new[] { ERROR ,  0}, new[] { ACTION, 20},
                new[] { ACTION, 20}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { GO_TO , 63}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { SHIFT , 16}, new[] { ERROR ,  0}, new[] { SHIFT ,  5}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT ,  8}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { SHIFT , 10}, new[] { SHIFT , 12}, new[] { SHIFT , 13}, new[] { SHIFT , 14},
                new[] { SHIFT , 15}, new[] { GO_TO , 64}, new[] { GO_TO ,  2}, new[] { GO_TO ,  3}, new[] { GO_TO ,  4},
                new[] { GO_TO ,  6}, new[] { GO_TO ,  7}, new[] { GO_TO ,  9}, new[] { GO_TO , 11}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { REDUCE, 23},
                new[] { REDUCE, 23}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION, 21}, new[] { ERROR ,  0}, new[] { ACTION, 21}, new[] { ACTION, 21}, new[] { ACTION, 21},
                new[] { ACTION, 21}, new[] { ACTION, 21}, new[] { ACTION, 21}, new[] { ERROR ,  0}, new[] { ACTION, 21},
                new[] { ACTION, 21}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { GO_TO , 65}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ACTION, 17}, new[] { ERROR ,  0}, new[] { ACTION, 17}, new[] { ACTION, 17}, new[] { ACTION, 17},
                new[] { ACTION, 17}, new[] { ACTION, 17}, new[] { ACTION, 17}, new[] { ERROR ,  0}, new[] { ACTION, 17},
                new[] { ACTION, 17}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 66}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE, 20}, new[] { ERROR ,  0}, new[] { REDUCE, 20}, new[] { REDUCE, 20}, new[] { REDUCE, 20},
                new[] { REDUCE, 20}, new[] { REDUCE, 20}, new[] { REDUCE, 20}, new[] { ERROR ,  0}, new[] { REDUCE, 20},
                new[] { REDUCE, 20}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { SHIFT , 17}, new[] { SHIFT , 18}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ACTION,  4},
                new[] { ACTION,  4}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { GO_TO , 67},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE, 21}, new[] { ERROR ,  0}, new[] { REDUCE, 21}, new[] { REDUCE, 21}, new[] { REDUCE, 21},
                new[] { REDUCE, 21}, new[] { REDUCE, 21}, new[] { REDUCE, 21}, new[] { ERROR ,  0}, new[] { REDUCE, 21},
                new[] { REDUCE, 21}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { REDUCE, 17}, new[] { ERROR ,  0}, new[] { REDUCE, 17}, new[] { REDUCE, 17}, new[] { REDUCE, 17},
                new[] { REDUCE, 17}, new[] { REDUCE, 17}, new[] { REDUCE, 17}, new[] { ERROR ,  0}, new[] { REDUCE, 17},
                new[] { REDUCE, 17}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            },
            new[]
            {
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { REDUCE, 22},
                new[] { REDUCE, 22}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0},
                new[] { ERROR ,  0}, new[] { ERROR ,  0}, new[] { ERROR ,  0}
            }
        };

        public static readonly int[][] PRODUCTIONS =
        {
            new[] { 17, 4 },
            new[] { 17, 4 },
            new[] { 17, 1 },
            new[] { 18, 4 },
            new[] { 18, 4 },
            new[] { 18, 4 },
            new[] { 18, 1 },
            new[] { 19, 4 },
            new[] { 19, 1 },
            new[] { 20, 3 },
            new[] { 20, 1 },
            new[] { 21, 1 },
            new[] { 21, 3 },
            new[] { 21, 1 },
            new[] { 22, 2 },
            new[] { 22, 1 },
            new[] { 24, 2 },
            new[] { 23, 7 },
            new[] { 23, 5 },
            new[] { 23, 5 },
            new[] { 23, 6 },
            new[] { 23, 6 },
            new[] { 25, 4 },
            new[] { 25, 2 }
        };

    }

}