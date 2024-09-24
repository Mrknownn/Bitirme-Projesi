"use client";

import TrendingNowDetailPage from '../page'

const TrendingNowDetail = ({ params }) => {

    if (params.id)
        return <TrendingNowDetailPage id={params.id} />;
};

export default TrendingNowDetail