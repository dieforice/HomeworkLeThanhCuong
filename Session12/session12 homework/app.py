from flask import *
app = Flask(__name__)


@app.route('/')
def index():
    return render_template("index.html")


@app.route('/school')
def redirecturl():
    return redirect("http://techkids.vn/")


if __name__ == '__main__':
    app.run(debug=True)
