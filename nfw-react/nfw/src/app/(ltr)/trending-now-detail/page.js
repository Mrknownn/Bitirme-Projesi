"use client"
import Layout from "@/components/ltr/layout/layout";
import { formatDate } from "@/components/ltr/utils/dateFormatter";
import axios from "axios";
import Link from "next/link";
import { useEffect, useState } from "react";
import StickyBox from "react-sticky-box";

const TrendingNowDetailPage = ({ id }) => {

  const [trendingNow, setTrendingNow] = useState({})
  useEffect(() => {
    if (id) {
      fetchTrends();
    }
  }, [id]);

  const fetchTrends = async () => {
    try {
      const response = await axios.get(`https://localhost:7272/api/TrendingNow/${id}`);
      setTrendingNow(response.data);
    } catch (error) {
      console.error('Error fetching news', error);
    }
  };

  return (
    <Layout>
      <main className="page_main_wrapper">
        <div className="page-title">
          <div className="container">
            <div className="align-items-center row">
              <div className="col">
                <h1 className="mb-sm-0">
                  <strong>Trending</strong> Now
                </h1>
              </div>
              <div className="col-12 col-sm-auto">
                <nav aria-label="breadcrumb">
                  <ol className="breadcrumb d-inline-block">
                    <li className="breadcrumb-item">
                      <Link href="/">Home</Link>
                    </li>
                    <li className="breadcrumb-item active" aria-current="page">
                      Trending Now Detail
                    </li>
                  </ol>
                </nav>
              </div>
            </div>
          </div>
        </div>
        <div className="container">
          <div className="row row-m">
            <div className="col-md-12 col-p main-content">
              <StickyBox>
                <div className="post_details_inner">
                  <div className="post_details_block">
                    <figure className="social-icon">
                      <img
                        src="assets/images/details-690x460-1.jpg"
                        className="img-fluid"
                        alt=""
                      />
                    </figure>
                    <h2>
                      {trendingNow.trendingNowTitle}
                    </h2>
                    <ul className="authar-info d-flex flex-wrap">
                      <li>
                        by {trendingNow.trendingNowAuthor}
                      </li>
                      <li>{trendingNow ? formatDate(trendingNow.trendingNowDate) : '-'}</li>

                    </ul>
                    <p>
                      {trendingNow.trendingNowDescription}
                    </p>
                  </div>
                </div>
              </StickyBox>
            </div>

          </div>
        </div>
      </main>
    </Layout>
  );
};

export default TrendingNowDetailPage;