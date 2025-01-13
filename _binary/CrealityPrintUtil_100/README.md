# CrealityPrint 6 プリセットビュワー

Crealityのスライサーソフト<b>CrealityPrint6</b>のフィラメントプリセットを表示させるビュワーです。<br>
<br>
スライサーで設定をいじってる時に他の設定が非常に確認しにくい。
比較の機能がついたが、その状態で設定は出来ないとかなり不幸な操作性だったので
作った物。<br>
<br>
他の機種の設定が表示されるので参考になると思います。


# Usage

* 左上の<b>System/User</b>でシステムプリセットとユーザープリセットの切り替え。<br>
* 横のコンボボックスで登録されてるフィラメントプリセットを選択
* 下のリストボックスに項目名（英語）と値が表示される。
* テキストボックスに入力された文字を含む項目のみ表示
* keyチェックボックスONでKeyが対象
* keyチェックボックスOFFで値が対象
* リストの項目をダブルクリックでダイアログが表示。コピー出来ます。

# ユーザープリセットの注意
ユーザープリセットは元となるシステムプリセットからの差分のみが保存される。<br>
つまり元となったプリセットが変更されるとそれに応じて変更される。最悪ユーザープリセットがエラーを起こしさくじょされてしまう。


# Dependency
Visual studio 2022 C#


# License

This software is released under the MIT License, see LICENSE

# Authors

bry-ful(Hiroshi Furuhashi)<br>
twitter:[bryful](https://twitter.com/bryful)<br>
bryful@gmail.com<br>

# References
