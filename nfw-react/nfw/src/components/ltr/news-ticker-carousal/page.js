
import dynamic from "next/dynamic";
import "owl.carousel/dist/assets/owl.carousel.css";
import "owl.carousel/dist/assets/owl.theme.default.css";
import 'animate.css/animate.css'
import { useEffect, useState } from "react";
import axios from "axios";
import Link from "next/link";


if (typeof window !== "undefined") {
  window.$ = window.jQuery = require("jquery");
}
// This is for Next.js. On Rect JS remove this line
const OwlCarousel = dynamic(() => import("react-owl-carousel"), {
  ssr: false,
});


const NewsTicker = () => {

  const [trendingNow, setTrendingNow] = useState([])
  useEffect(() => {
    fetchTrends();
  }, []);

  const fetchTrends = async () => {
    try {
      const response = await axios.get('https://localhost:7272/api/TrendingNow');
      setTrendingNow(response.data);
    } catch (error) {
      console.error('Error fetching news', error);
    }
  };
  if (trendingNow.length > 0)
    return (
      <div className="container">
        <div className="newstricker_inner">
          <div className="trending">
            <strong>Trending</strong> Now
          </div>
          <OwlCarousel className="news-ticker owl-theme"
            loop={true}
            items={1}
            dots={false}
            animateOut='animate__slideOutDown'
            animateIn='animate__flipInX'
            autoplay={true}
            autoplayTimeout={5000}
            autoplayHoverPause={true}
            nav={false}
            responsive={{
              0: {
                nav: false,
              },
              768: {
                nav: true,
                navText: [
                  "<i class='ti ti-angle-left'></i>",
                  "<i class='ti ti-angle-right'></i>"
                ],
              }
            }}>
            {trendingNow.map((item) => (<div className="item">
              <Link href={`trending-now-detail/${item.trendingNowID}`}>
                {item.trendingNowDescription}
              </Link>
            </div>))}
          </OwlCarousel>
        </div>
      </div>
    );
};

export default NewsTicker;