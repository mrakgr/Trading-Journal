let f (x : {|bb : float; hands : float; winrate_per_100_bb : float|}) =
    x.bb * x.hands * x.winrate_per_100_bb / 100.0

f {|
    bb = 2
    hands = 100_000
    winrate_per_100_bb = 3
|}
