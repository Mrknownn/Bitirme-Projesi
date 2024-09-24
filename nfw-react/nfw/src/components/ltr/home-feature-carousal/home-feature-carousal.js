
import dynamic from "next/dynamic";
import "owl.carousel/dist/assets/owl.carousel.css";
import "owl.carousel/dist/assets/owl.theme.default.css";
import 'animate.css/animate.css'
import axios from "axios";
import { useEffect, useState } from "react";

if (typeof window !== "undefined") {
  window.$ = window.jQuery = require("jquery");
}
// This is for Next.js. On Rect JS remove this line
const OwlCarousel = dynamic(() => import("react-owl-carousel"), {
  ssr: false,
});



const HomeFeatureCarousal = () => {

  const [recentPosts, setRecentPosts] = useState([])
  useEffect(() => {
    fetchRecent();
  }, []);

  const fetchRecent = async () => {
    try {
      const response = await axios.get('https://localhost:7272/api/RecentPost');
      setRecentPosts(response.data);
    } catch (error) {
      console.error('Error fetching recent', error);
    }
  };

  if (recentPosts.length > 0)
    return (
      <OwlCarousel className="owl-theme featured-carousel"
        loop={true}
        margin={10}
        nav={false}
        dots={false}
        responsive={{
          0: {
            items: 1,
            autoplay: true
          },
          576: {
            items: 2
          },
          768: {
            items: 2.5
          },
          992: {
            items: 3.5
          },
          1200: {
            items: 4
          }
        }}
      >
        {recentPosts.map((item) => (
          <div className="news-list-item">
            <div className="img-wrapper">
              <a href={`recentPostDetail/${item.recentPostID}`} className="thumb">
                <img
                  src={item.recentPostImageUrl}
                  alt=""
                  className="img-fluid"
                />
                <div className="link-icon">
                  <i className="fa fa-camera" />
                </div>
              </a>
            </div>
            <div className="post-info-2">
              <h5 className="mb-0">
                <a href="#" className="title">
                  {item.recentPostDescription}
                </a>
              </h5>
            </div>
          </div>
        ))}
      </OwlCarousel>
    );
};

export default HomeFeatureCarousal;