from PyQt5 import QtWidgets
import sys



if __name__ == '__main__':
    app = QtWidgets.QApplication(sys.argv)
    window = QtWidgets.QWidget()
    window.setWindowTitle("MKO")
    window.show()
    sys.exit(app.exec_())