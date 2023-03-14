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

        public static readonly string[] PARSER_ERROR =
        {
            "Erro estado 0",
            "Erro estado 1",
            "Erro estado 2",
            "Erro estado 3",
            "Erro estado 4",
            "Erro estado 5",
            "Erro estado 6",
            "Erro estado 7",
            "Erro estado 8",
            "Erro estado 9",
            "Erro estado 10",
            "Erro estado 11",
            "Erro estado 12",
            "Erro estado 13",
            "Erro estado 14",
            "Erro estado 15",
            "Erro estado 16",
            "Erro estado 17",
            "Erro estado 18",
            "Erro estado 19",
            "Erro estado 20",
            "Erro estado 21",
            "Erro estado 22",
            "Erro estado 23",
            "Erro estado 24",
            "Erro estado 25",
            "Erro estado 26",
            "Erro estado 27",
            "Erro estado 28",
            "Erro estado 29",
            "Erro estado 30",
            "Erro estado 31",
            "Erro estado 32",
            "Erro estado 33",
            "Erro estado 34",
            "Erro estado 35",
            "Erro estado 36",
            "Erro estado 37",
            "Erro estado 38",
            "Erro estado 39",
            "Erro estado 40",
            "Erro estado 41",
            "Erro estado 42",
            "Erro estado 43",
            "Erro estado 44",
            "Erro estado 45",
            "Erro estado 46",
            "Erro estado 47",
            "Erro estado 48",
            "Erro estado 49",
            "Erro estado 50",
            "Erro estado 51",
            "Erro estado 52",
            "Erro estado 53",
            "Erro estado 54",
            "Erro estado 55",
            "Erro estado 56",
            "Erro estado 57",
            "Erro estado 58",
            "Erro estado 59",
            "Erro estado 60",
            "Erro estado 61",
            "Erro estado 62",
            "Erro estado 63",
            "Erro estado 64",
            "Erro estado 65",
            "Erro estado 66",
            "Erro estado 67"
        };
    }

}