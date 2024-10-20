var pluginTrendlineLinear = {
    beforeDraw: function (e) {
        var s, a;
        for (var t in e.scales)
            if ("x" == t[0] ? a = e.scales[t] : s = e.scales[t], a && s) break;
        var r = e.chart.ctx;
        e.data.datasets.forEach(function (t, i) {
            t.trendlineLinear && e.isDatasetVisible(i) && addFitter(e.getDatasetMeta(i), r, t, a, s)
        }), r.setLineDash([])
    }
};

function addFitter(t, i, e, s, a) {
    var r = e.trendlineLinear.style || e.borderColor,
        n = e.trendlineLinear.width || e.borderWidth,
        o = e.trendlineLinear.lineStyle || "solid";
    r = void 0 !== r ? r : "rgba(169,169,169, .6)", n = void 0 !== n ? n : 3;
    var h = new LineFitter,
        d = e.data.length - 1,
        l = t.data[0]._model.x,
        u = t.data[d]._model.x,
        m = !1;
    e.data && "object" == typeof e.data[0] && (m = !0), e.data.forEach(function (t, i) {
        m ? h.add(t.x, t.y) : h.add(i, t)
    });
    var c = s.getPixelForValue(h.minx),
        x = s.getPixelForValue(h.maxx),
        f = a.getPixelForValue(h.f(h.minx)),
        X = a.getPixelForValue(h.f(h.maxx));
    m || (c = l, x = u);
    var v = t.controller.chart.chartArea.bottom,
        g = t.controller.chart.width;
    if (v < f) {
        var L = f - v,
            b = f - X;
        f = v, c += g * (L / b)
    } else if (v < X) {
        L = X - v, b = X - f;
        X = v, x = g - (x - (g - g * (L / b)))
    }
    i.lineWidth = n, "dotted" === o && i.setLineDash([2, 3]), i.beginPath(), i.moveTo(c, f), i.lineTo(x, X), i.strokeStyle = r, i.stroke()
}

function LineFitter() {
    this.count = 0, this.sumX = 0, this.sumX2 = 0, this.sumXY = 0, this.sumY = 0, this.minx = 1e100, this.maxx = -1e100
}
Chart.plugins.register(pluginTrendlineLinear), LineFitter.prototype = {
    add: function (t, i) {
        this.count++, this.sumX += t, this.sumX2 += t * t, this.sumXY += t * i, this.sumY += i, t < this.minx && (this.minx = t), t > this.maxx && (this.maxx = t)
    },
    f: function (t) {
        var i = this.count * this.sumX2 - this.sumX * this.sumX;
        return (this.sumX2 * this.sumY - this.sumX * this.sumXY) / i + t * ((this.count * this.sumXY - this.sumX * this.sumY) / i)
    }
};